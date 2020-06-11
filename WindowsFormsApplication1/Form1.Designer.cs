namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtNowValue = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnOpenSerialPort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.cmbPort = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSelectWriteFequency = new System.Windows.Forms.Button();
            this.cmbWriteFequency = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTxtReData = new System.Windows.Forms.RichTextBox();
            this.g = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSelectTime = new System.Windows.Forms.ComboBox();
            this.btnPhotoSave = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.g.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNowValue
            // 
            this.txtNowValue.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNowValue.ForeColor = System.Drawing.Color.Red;
            this.txtNowValue.Location = new System.Drawing.Point(60, 68);
            this.txtNowValue.Name = "txtNowValue";
            this.txtNowValue.Size = new System.Drawing.Size(71, 23);
            this.txtNowValue.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM5";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceive);
            // 
            // btnOpenSerialPort
            // 
            this.btnOpenSerialPort.Location = new System.Drawing.Point(230, 139);
            this.btnOpenSerialPort.Name = "btnOpenSerialPort";
            this.btnOpenSerialPort.Size = new System.Drawing.Size(75, 23);
            this.btnOpenSerialPort.TabIndex = 1;
            this.btnOpenSerialPort.Text = "打开串口";
            this.btnOpenSerialPort.UseVisualStyleBackColor = true;
            this.btnOpenSerialPort.Click += new System.EventHandler(this.btnOpenSerialPort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(58, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "当前值";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(163, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "最大值";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(270, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "最小值";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMax
            // 
            this.txtMax.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMax.ForeColor = System.Drawing.Color.Red;
            this.txtMax.Location = new System.Drawing.Point(167, 67);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(68, 23);
            this.txtMax.TabIndex = 3;
            // 
            // txtMin
            // 
            this.txtMin.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMin.ForeColor = System.Drawing.Color.Red;
            this.txtMin.Location = new System.Drawing.Point(274, 68);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(74, 23);
            this.txtMin.TabIndex = 4;
            // 
            // cmbPort
            // 
            this.cmbPort.FormattingEnabled = true;
            this.cmbPort.Location = new System.Drawing.Point(62, 139);
            this.cmbPort.Name = "cmbPort";
            this.cmbPort.Size = new System.Drawing.Size(121, 20);
            this.cmbPort.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(41, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 172);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "功率值显示";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbSelectTime);
            this.groupBox2.Controls.Add(this.btnSelectWriteFequency);
            this.groupBox2.Controls.Add(this.cmbWriteFequency);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(41, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(340, 135);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "采样参数设置";
            // 
            // btnSelectWriteFequency
            // 
            this.btnSelectWriteFequency.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSelectWriteFequency.Location = new System.Drawing.Point(189, 46);
            this.btnSelectWriteFequency.Name = "btnSelectWriteFequency";
            this.btnSelectWriteFequency.Size = new System.Drawing.Size(75, 23);
            this.btnSelectWriteFequency.TabIndex = 1;
            this.btnSelectWriteFequency.Text = "开始采样";
            this.btnSelectWriteFequency.UseVisualStyleBackColor = true;
            this.btnSelectWriteFequency.Click += new System.EventHandler(this.btnSelectWriteFequency_Click);
            // 
            // cmbWriteFequency
            // 
            this.cmbWriteFequency.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbWriteFequency.FormattingEnabled = true;
            this.cmbWriteFequency.Location = new System.Drawing.Point(19, 44);
            this.cmbWriteFequency.Name = "cmbWriteFequency";
            this.cmbWriteFequency.Size = new System.Drawing.Size(121, 25);
            this.cmbWriteFequency.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPhotoSave);
            this.groupBox3.Controls.Add(this.chart1);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(41, 353);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(690, 359);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "图表显示";
            // 
            // richTxtReData
            // 
            this.richTxtReData.Font = new System.Drawing.Font("微软雅黑", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTxtReData.Location = new System.Drawing.Point(6, 22);
            this.richTxtReData.Name = "richTxtReData";
            this.richTxtReData.Size = new System.Drawing.Size(321, 300);
            this.richTxtReData.TabIndex = 9;
            this.richTxtReData.Text = "";
            this.richTxtReData.TextChanged += new System.EventHandler(this.richTextChanged);
            // 
            // g
            // 
            this.g.Controls.Add(this.richTxtReData);
            this.g.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.g.Location = new System.Drawing.Point(398, 19);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(333, 328);
            this.g.TabIndex = 10;
            this.g.TabStop = false;
            this.g.Text = "数值历史记录";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(17, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "采样频率（s）";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(17, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "采样时间（m）";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbSelectTime
            // 
            this.cmbSelectTime.FormattingEnabled = true;
            this.cmbSelectTime.Location = new System.Drawing.Point(19, 96);
            this.cmbSelectTime.Name = "cmbSelectTime";
            this.cmbSelectTime.Size = new System.Drawing.Size(121, 27);
            this.cmbSelectTime.TabIndex = 3;
            // 
            // btnPhotoSave
            // 
            this.btnPhotoSave.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPhotoSave.Location = new System.Drawing.Point(609, 69);
            this.btnPhotoSave.Name = "btnPhotoSave";
            this.btnPhotoSave.Size = new System.Drawing.Size(75, 23);
            this.btnPhotoSave.TabIndex = 0;
            this.btnPhotoSave.Text = "图表保存（save）";
            this.btnPhotoSave.UseVisualStyleBackColor = true;
            this.btnPhotoSave.Click += new System.EventHandler(this.btnPhotoSave_Click);
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(6, 25);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(720, 328);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 724);
            this.Controls.Add(this.g);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmbPort);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.txtMax);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenSerialPort);
            this.Controls.Add(this.txtNowValue);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.g.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNowValue;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnOpenSerialPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.ComboBox cmbPort;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSelectWriteFequency;
        private System.Windows.Forms.ComboBox cmbWriteFequency;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTxtReData;
        private System.Windows.Forms.GroupBox g;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cmbSelectTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPhotoSave;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

