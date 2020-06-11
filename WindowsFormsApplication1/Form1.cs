using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.IO;
using System.Data.OleDb;
using System.Data.SqlClient;
using CCWin;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        int valueMax, valueMin, valueNow;
        string writeNow, writeMax, writeMin;
        string writeTxt;
        byte[]receiveByteData={};

        bool serialSwitch;
        bool samplingSwitch;

        int coutTime;//总计数
        double[] crawlData = new double[100000];//采集点
        public Form1()
        {

            InitializeComponent();
            txtMax.Enabled = false;
            txtMin.Enabled = false;
            txtNowValue.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string[] ports = SerialPort.GetPortNames();
                foreach (string port in ports)
                {
                    cmbPort.Items.Add(port);
                }
                cmbPort.SelectedIndex = 0;

                cmbWriteFequency.Items.Add("1");
                cmbWriteFequency.Items.Add("5");
                cmbWriteFequency.Items.Add("10");
                cmbWriteFequency.Items.Add("30");
                cmbWriteFequency.Items.Add("60");
                cmbWriteFequency.SelectedIndex  = 0;


                cmbSelectTime.Items.Add("5");
                cmbSelectTime.Items.Add("10");
                cmbSelectTime.Items.Add("15");
                cmbSelectTime.Items.Add("20");
                cmbSelectTime.Items.Add("30");
                cmbSelectTime.Items.Add("45");
                cmbSelectTime.Items.Add("60");
                cmbSelectTime.Items.Add("90");
                cmbSelectTime.Items.Add("120");
                cmbSelectTime.Items.Add("9999");
                cmbSelectTime.SelectedIndex = 0;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
                return;
            }
        }
        private void serialPort_DataReceive(object sender, SerialDataReceivedEventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            Thread.Sleep(30);
            int valueTenthousand, valueThousand, valueHundred,valueTen, valueAone;
            try
            {
                if (this.serialPort1.BytesToRead>0)
                {
                    receiveByteData=null;
                    byte[] buffer=new byte [10];
                    this.serialPort1.Read(buffer,0,buffer.Length);

                        if (buffer[0]==170&&buffer[1]==170&&buffer[2]==170)
	                    {
		                    valueTenthousand=buffer[3];
                            valueThousand = buffer[4];
                            valueHundred = buffer[5];
                            valueTen = buffer[ 6];
                            valueAone = buffer[7];
                            txtNowValue.Text = valueTenthousand.ToString() + valueThousand.ToString() + valueHundred.ToString() + valueTen.ToString() + valueAone.ToString();
                            int temp;
                            temp = valueTenthousand * 10000 + valueThousand * 1000 + valueHundred * 100 + valueTen * 10 + valueAone;
                            valueNow = temp;
                            if (valueMax<temp)
                            {
                                valueMax = temp;
                            }
                            if (valueMin>temp)
                            {
                                valueMin= temp;
                            }
                            txtMax.Text = valueMax.ToString();
                            txtMin.Text = valueMin.ToString();
                            writeMax = valueMax.ToString();
                            writeMin = valueMin.ToString();
                            writeNow = temp.ToString();
                            writeTxt = writeNow + "   " + writeMax + "   " + writeMin + "   ";
	                    }

                }
                serialPort1.DiscardInBuffer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                coutTime = coutTime + 1;
                File.AppendAllText("data.txt", "\r\n" + DateTime.Now.ToString("yy-MM-dd HH:mm:ss") + "    " + writeTxt);
                richTxtReData.Text += ("\r\n" + DateTime.Now.ToString("yy-MM-dd HH:mm:ss") + "    " + writeTxt + timer1.Interval.ToString());
                //画图
                crawlData[coutTime] = valueNow;
                chart1.Series.Clear();
                Series series = new Series("Value");
                series.ChartType = SeriesChartType.Spline;
                series.BorderWidth = 3;
                series.ShadowOffset = 2;

                for (int i = 0; i <= coutTime; i++)
                {
                    series.Points.AddY(crawlData[i]);
                }
                chart1.Series.Add(series);
            }
            
            
        }
        private void btnOpenSerialPort_Click(object sender, EventArgs e)
        {

            serialSwitch = !serialSwitch;
            try
            {
                if (serialSwitch)
                {
                    serialPort1.Close();
                    serialPort1.PortName = cmbPort.Text;
                    serialPort1.BaudRate = 2400;
                    serialPort1.DataBits = 8;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Parity = Parity.None;
                    serialPort1.Open();
                    btnOpenSerialPort.Text = "关闭串口";
                    MessageBox.Show(cmbPort.Text, "串口打开成功");
                    valueMin = 99999;
                    valueMax = 0;
                   // timer1.Start();
                }
                else
                {
                    serialPort1.Close();
                    btnOpenSerialPort.Text = "打开串口";
                    valueMin = 99999;
                    valueMax = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误");
                return;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectWriteFequency_Click(object sender, EventArgs e)
        {
            samplingSwitch = !samplingSwitch;
            if (samplingSwitch)
            {
                timer1.Enabled = true;
                btnSelectWriteFequency.Text = ("暂停采样");
            }
            else
            {
                timer1.Enabled = false;
                btnSelectWriteFequency.Text = ("开始采样");
            }
            timer1.Interval = int.Parse(cmbWriteFequency.Text) * 1000;

        }

        private void richTextChanged(object sender, EventArgs e)
        {
            richTxtReData.SelectionStart = richTxtReData.Text.Length;
            richTxtReData.ScrollToCaret();
        }

        private void btnPhotoSave_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.Filter = "JPEG文件|*.jpg";
                if (savefile.ShowDialog() == DialogResult.OK)
                {

                    chart1.SaveImage(savefile.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "错误提示");
                return;
            } 
        }
    }
}
