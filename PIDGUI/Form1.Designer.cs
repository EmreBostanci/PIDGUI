namespace PIDGUI
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btConnect = new System.Windows.Forms.Button();
            this.cbPorts = new System.Windows.Forms.ComboBox();
            this.cbBouds = new System.Windows.Forms.ComboBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbKp = new System.Windows.Forms.Label();
            this.tbKp = new System.Windows.Forms.TextBox();
            this.lbKi = new System.Windows.Forms.Label();
            this.tbKi = new System.Windows.Forms.TextBox();
            this.lbKd = new System.Windows.Forms.Label();
            this.tbKd = new System.Windows.Forms.TextBox();
            this.lbReceivedKp = new System.Windows.Forms.Label();
            this.lbReceivedKi = new System.Windows.Forms.Label();
            this.lbReceivedKd = new System.Windows.Forms.Label();
            this.lbSet = new System.Windows.Forms.Label();
            this.lbReceivedSet = new System.Windows.Forms.Label();
            this.tbSet = new System.Windows.Forms.TextBox();
            this.pbOut = new System.Windows.Forms.PictureBox();
            this.pbOutFront = new System.Windows.Forms.PictureBox();
            this.lbOutZero = new System.Windows.Forms.Label();
            this.lbOutMaxV = new System.Windows.Forms.Label();
            this.lbOutValue = new System.Windows.Forms.Label();
            this.lbSample = new System.Windows.Forms.Label();
            this.lbReceivedSample = new System.Windows.Forms.Label();
            this.tbSample = new System.Windows.Forms.TextBox();
            this.btReset = new System.Windows.Forms.Button();
            this.lbOutBottom = new System.Windows.Forms.Label();
            this.btGraphDelete = new System.Windows.Forms.Button();
            this.tbChartYsize = new System.Windows.Forms.TrackBar();
            this.lbTrackYaxes = new System.Windows.Forms.Label();
            this.lbReceiveDataFormat = new System.Windows.Forms.Label();
            this.lbTrasmitDataFormat = new System.Windows.Forms.Label();
            this.btSend = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutFront)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbChartYsize)).BeginInit();
            this.SuspendLayout();
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(300, 11);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(136, 21);
            this.btConnect.TabIndex = 3;
            this.btConnect.Text = "Bağlan";
            this.btConnect.UseVisualStyleBackColor = true;
            this.btConnect.Click += new System.EventHandler(this.btConnect_Click);
            // 
            // cbPorts
            // 
            this.cbPorts.FormattingEnabled = true;
            this.cbPorts.Location = new System.Drawing.Point(12, 11);
            this.cbPorts.Name = "cbPorts";
            this.cbPorts.Size = new System.Drawing.Size(121, 21);
            this.cbPorts.TabIndex = 1;
            // 
            // cbBouds
            // 
            this.cbBouds.FormattingEnabled = true;
            this.cbBouds.Location = new System.Drawing.Point(156, 11);
            this.cbBouds.Name = "cbBouds";
            this.cbBouds.Size = new System.Drawing.Size(121, 21);
            this.cbBouds.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(12, 38);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.Name = "Input";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Brown;
            series2.Name = "Set";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1314, 363);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // lbKp
            // 
            this.lbKp.AutoSize = true;
            this.lbKp.Location = new System.Drawing.Point(110, 411);
            this.lbKp.Name = "lbKp";
            this.lbKp.Size = new System.Drawing.Size(20, 13);
            this.lbKp.TabIndex = 4;
            this.lbKp.Text = "Kp";
            // 
            // tbKp
            // 
            this.tbKp.Location = new System.Drawing.Point(136, 407);
            this.tbKp.Name = "tbKp";
            this.tbKp.Size = new System.Drawing.Size(104, 20);
            this.tbKp.TabIndex = 4;
            this.tbKp.Text = "10";
            // 
            // lbKi
            // 
            this.lbKi.AutoSize = true;
            this.lbKi.Location = new System.Drawing.Point(110, 437);
            this.lbKi.Name = "lbKi";
            this.lbKi.Size = new System.Drawing.Size(16, 13);
            this.lbKi.TabIndex = 4;
            this.lbKi.Text = "Ki";
            // 
            // tbKi
            // 
            this.tbKi.Location = new System.Drawing.Point(136, 433);
            this.tbKi.Name = "tbKi";
            this.tbKi.Size = new System.Drawing.Size(104, 20);
            this.tbKi.TabIndex = 5;
            this.tbKi.Text = "8";
            // 
            // lbKd
            // 
            this.lbKd.AutoSize = true;
            this.lbKd.Location = new System.Drawing.Point(110, 463);
            this.lbKd.Name = "lbKd";
            this.lbKd.Size = new System.Drawing.Size(20, 13);
            this.lbKd.TabIndex = 4;
            this.lbKd.Text = "Kd";
            // 
            // tbKd
            // 
            this.tbKd.Location = new System.Drawing.Point(136, 459);
            this.tbKd.Name = "tbKd";
            this.tbKd.Size = new System.Drawing.Size(104, 20);
            this.tbKd.TabIndex = 6;
            this.tbKd.Text = "0.05";
            // 
            // lbReceivedKp
            // 
            this.lbReceivedKp.AutoSize = true;
            this.lbReceivedKp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbReceivedKp.Location = new System.Drawing.Point(244, 411);
            this.lbReceivedKp.Name = "lbReceivedKp";
            this.lbReceivedKp.Size = new System.Drawing.Size(10, 13);
            this.lbReceivedKp.TabIndex = 4;
            this.lbReceivedKp.Text = "-";
            // 
            // lbReceivedKi
            // 
            this.lbReceivedKi.AutoSize = true;
            this.lbReceivedKi.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbReceivedKi.Location = new System.Drawing.Point(244, 437);
            this.lbReceivedKi.Name = "lbReceivedKi";
            this.lbReceivedKi.Size = new System.Drawing.Size(10, 13);
            this.lbReceivedKi.TabIndex = 4;
            this.lbReceivedKi.Text = "-";
            // 
            // lbReceivedKd
            // 
            this.lbReceivedKd.AutoSize = true;
            this.lbReceivedKd.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbReceivedKd.Location = new System.Drawing.Point(244, 463);
            this.lbReceivedKd.Name = "lbReceivedKd";
            this.lbReceivedKd.Size = new System.Drawing.Size(10, 13);
            this.lbReceivedKd.TabIndex = 4;
            this.lbReceivedKd.Text = "-";
            // 
            // lbSet
            // 
            this.lbSet.AutoSize = true;
            this.lbSet.Location = new System.Drawing.Point(307, 411);
            this.lbSet.Name = "lbSet";
            this.lbSet.Size = new System.Drawing.Size(23, 13);
            this.lbSet.TabIndex = 4;
            this.lbSet.Text = "Set";
            // 
            // lbReceivedSet
            // 
            this.lbReceivedSet.AutoSize = true;
            this.lbReceivedSet.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbReceivedSet.Location = new System.Drawing.Point(487, 411);
            this.lbReceivedSet.Name = "lbReceivedSet";
            this.lbReceivedSet.Size = new System.Drawing.Size(10, 13);
            this.lbReceivedSet.TabIndex = 4;
            this.lbReceivedSet.Text = "-";
            // 
            // tbSet
            // 
            this.tbSet.Location = new System.Drawing.Point(379, 407);
            this.tbSet.Name = "tbSet";
            this.tbSet.Size = new System.Drawing.Size(104, 20);
            this.tbSet.TabIndex = 7;
            this.tbSet.Text = "200";
            // 
            // pbOut
            // 
            this.pbOut.BackColor = System.Drawing.Color.Gray;
            this.pbOut.Location = new System.Drawing.Point(1332, 60);
            this.pbOut.Name = "pbOut";
            this.pbOut.Size = new System.Drawing.Size(30, 200);
            this.pbOut.TabIndex = 6;
            this.pbOut.TabStop = false;
            this.pbOut.Tag = "pbOut";
            // 
            // pbOutFront
            // 
            this.pbOutFront.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.pbOutFront.Location = new System.Drawing.Point(1332, 60);
            this.pbOutFront.Name = "pbOutFront";
            this.pbOutFront.Size = new System.Drawing.Size(30, 300);
            this.pbOutFront.TabIndex = 6;
            this.pbOutFront.TabStop = false;
            // 
            // lbOutZero
            // 
            this.lbOutZero.AutoSize = true;
            this.lbOutZero.Location = new System.Drawing.Point(1368, 356);
            this.lbOutZero.Name = "lbOutZero";
            this.lbOutZero.Size = new System.Drawing.Size(13, 13);
            this.lbOutZero.TabIndex = 7;
            this.lbOutZero.Text = "0";
            // 
            // lbOutMaxV
            // 
            this.lbOutMaxV.AutoSize = true;
            this.lbOutMaxV.Location = new System.Drawing.Point(1368, 49);
            this.lbOutMaxV.Name = "lbOutMaxV";
            this.lbOutMaxV.Size = new System.Drawing.Size(25, 13);
            this.lbOutMaxV.TabIndex = 7;
            this.lbOutMaxV.Text = "255";
            // 
            // lbOutValue
            // 
            this.lbOutValue.AutoSize = true;
            this.lbOutValue.Location = new System.Drawing.Point(1368, 247);
            this.lbOutValue.Name = "lbOutValue";
            this.lbOutValue.Size = new System.Drawing.Size(57, 13);
            this.lbOutValue.TabIndex = 8;
            this.lbOutValue.Text = "Output Val";
            // 
            // lbSample
            // 
            this.lbSample.AutoSize = true;
            this.lbSample.Location = new System.Drawing.Point(307, 437);
            this.lbSample.Name = "lbSample";
            this.lbSample.Size = new System.Drawing.Size(68, 13);
            this.lbSample.TabIndex = 4;
            this.lbSample.Text = "Sample Time";
            // 
            // lbReceivedSample
            // 
            this.lbReceivedSample.AutoSize = true;
            this.lbReceivedSample.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbReceivedSample.Location = new System.Drawing.Point(487, 437);
            this.lbReceivedSample.Name = "lbReceivedSample";
            this.lbReceivedSample.Size = new System.Drawing.Size(10, 13);
            this.lbReceivedSample.TabIndex = 4;
            this.lbReceivedSample.Text = "-";
            // 
            // tbSample
            // 
            this.tbSample.Location = new System.Drawing.Point(379, 433);
            this.tbSample.Name = "tbSample";
            this.tbSample.Size = new System.Drawing.Size(104, 20);
            this.tbSample.TabIndex = 8;
            this.tbSample.Text = "50";
            // 
            // btReset
            // 
            this.btReset.ForeColor = System.Drawing.Color.Red;
            this.btReset.Location = new System.Drawing.Point(1251, 405);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 39);
            this.btReset.TabIndex = 9;
            this.btReset.Text = "Reset Arduino";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // lbOutBottom
            // 
            this.lbOutBottom.AutoSize = true;
            this.lbOutBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOutBottom.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbOutBottom.Location = new System.Drawing.Point(1329, 369);
            this.lbOutBottom.Name = "lbOutBottom";
            this.lbOutBottom.Size = new System.Drawing.Size(46, 16);
            this.lbOutBottom.TabIndex = 10;
            this.lbOutBottom.Text = "Output";
            // 
            // btGraphDelete
            // 
            this.btGraphDelete.Location = new System.Drawing.Point(1167, 405);
            this.btGraphDelete.Name = "btGraphDelete";
            this.btGraphDelete.Size = new System.Drawing.Size(83, 39);
            this.btGraphDelete.TabIndex = 11;
            this.btGraphDelete.Text = "Chart Reset";
            this.btGraphDelete.UseVisualStyleBackColor = true;
            this.btGraphDelete.Click += new System.EventHandler(this.btGraphDelete_Click);
            // 
            // tbChartYsize
            // 
            this.tbChartYsize.Location = new System.Drawing.Point(871, 405);
            this.tbChartYsize.Maximum = 10000;
            this.tbChartYsize.Minimum = 100;
            this.tbChartYsize.Name = "tbChartYsize";
            this.tbChartYsize.Size = new System.Drawing.Size(290, 45);
            this.tbChartYsize.TabIndex = 12;
            this.tbChartYsize.Tag = "Chart Y Eksen Uzunluğu";
            this.tbChartYsize.Value = 100;
            this.tbChartYsize.ValueChanged += new System.EventHandler(this.tbChartYsize_ValueChanged);
            // 
            // lbTrackYaxes
            // 
            this.lbTrackYaxes.AutoSize = true;
            this.lbTrackYaxes.Location = new System.Drawing.Point(882, 437);
            this.lbTrackYaxes.Name = "lbTrackYaxes";
            this.lbTrackYaxes.Size = new System.Drawing.Size(76, 13);
            this.lbTrackYaxes.TabIndex = 13;
            this.lbTrackYaxes.Text = "X Ekseni Boyu";
            // 
            // lbReceiveDataFormat
            // 
            this.lbReceiveDataFormat.AutoSize = true;
            this.lbReceiveDataFormat.Location = new System.Drawing.Point(1130, 453);
            this.lbReceiveDataFormat.Name = "lbReceiveDataFormat";
            this.lbReceiveDataFormat.Size = new System.Drawing.Size(296, 13);
            this.lbReceiveDataFormat.TabIndex = 14;
            this.lbReceiveDataFormat.Text = "Receive Data Format: Kp | Ki | Kd | Input | Out | Setpoint \"\\n\" ";
            // 
            // lbTrasmitDataFormat
            // 
            this.lbTrasmitDataFormat.AutoSize = true;
            this.lbTrasmitDataFormat.Location = new System.Drawing.Point(1130, 475);
            this.lbTrasmitDataFormat.Name = "lbTrasmitDataFormat";
            this.lbTrasmitDataFormat.Size = new System.Drawing.Size(295, 13);
            this.lbTrasmitDataFormat.TabIndex = 14;
            this.lbTrasmitDataFormat.Text = "Transmit Data Format: Kp | Ki | Kd | Set | Sample | Reset \"\\n\" ";
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(379, 462);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(104, 23);
            this.btSend.TabIndex = 15;
            this.btSend.Text = "Gönder";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 497);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.lbTrasmitDataFormat);
            this.Controls.Add(this.lbReceiveDataFormat);
            this.Controls.Add(this.lbTrackYaxes);
            this.Controls.Add(this.tbChartYsize);
            this.Controls.Add(this.btGraphDelete);
            this.Controls.Add(this.lbOutBottom);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.lbOutValue);
            this.Controls.Add(this.lbOutMaxV);
            this.Controls.Add(this.lbOutZero);
            this.Controls.Add(this.tbKd);
            this.Controls.Add(this.lbReceivedKd);
            this.Controls.Add(this.lbKd);
            this.Controls.Add(this.tbKi);
            this.Controls.Add(this.lbReceivedKi);
            this.Controls.Add(this.lbKi);
            this.Controls.Add(this.tbSample);
            this.Controls.Add(this.lbReceivedSample);
            this.Controls.Add(this.tbSet);
            this.Controls.Add(this.lbReceivedSet);
            this.Controls.Add(this.lbSample);
            this.Controls.Add(this.tbKp);
            this.Controls.Add(this.lbSet);
            this.Controls.Add(this.lbReceivedKp);
            this.Controls.Add(this.lbKp);
            this.Controls.Add(this.cbBouds);
            this.Controls.Add(this.cbPorts);
            this.Controls.Add(this.btConnect);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pbOut);
            this.Controls.Add(this.pbOutFront);
            this.Name = "Form1";
            this.Text = "PID_GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOutFront)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbChartYsize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btConnect;
        private System.Windows.Forms.ComboBox cbPorts;
        private System.Windows.Forms.ComboBox cbBouds;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbKp;
        private System.Windows.Forms.TextBox tbKp;
        private System.Windows.Forms.Label lbKi;
        private System.Windows.Forms.TextBox tbKi;
        private System.Windows.Forms.Label lbKd;
        private System.Windows.Forms.TextBox tbKd;
        private System.Windows.Forms.Label lbReceivedKp;
        private System.Windows.Forms.Label lbReceivedKi;
        private System.Windows.Forms.Label lbReceivedKd;
        private System.Windows.Forms.Label lbSet;
        private System.Windows.Forms.Label lbReceivedSet;
        private System.Windows.Forms.TextBox tbSet;
        private System.Windows.Forms.PictureBox pbOut;
        private System.Windows.Forms.PictureBox pbOutFront;
        private System.Windows.Forms.Label lbOutZero;
        private System.Windows.Forms.Label lbOutMaxV;
        private System.Windows.Forms.Label lbOutValue;
        private System.Windows.Forms.Label lbSample;
        private System.Windows.Forms.Label lbReceivedSample;
        private System.Windows.Forms.TextBox tbSample;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label lbOutBottom;
        private System.Windows.Forms.Button btGraphDelete;
        private System.Windows.Forms.TrackBar tbChartYsize;
        private System.Windows.Forms.Label lbTrackYaxes;
        private System.Windows.Forms.Label lbReceiveDataFormat;
        private System.Windows.Forms.Label lbTrasmitDataFormat;
        private System.Windows.Forms.Button btSend;
    }
}

