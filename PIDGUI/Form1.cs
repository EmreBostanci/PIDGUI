using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Globalization;

namespace PIDGUI
{   
    public partial class Form1 : Form
    {
        
        string[] portlar = SerialPort.GetPortNames();
        SerialPort SP = new SerialPort();
        public string Kp, Ki, Kd, Input, SetPoint, Output,Sample;
        public string indata;
        string[] parts;
        double chartXMin, chartXmax=20,Ysize = 100;
        double ValueForTryParse;
        string ResetVal = "";

        public Form1()
        {
            
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.WhiteSmoke;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.WhiteSmoke;

            btConnect.ForeColor = Color.PaleVioletRed;
            btConnect.BackColor = Color.LightYellow;
            btConnect.Text = "Bağlan";

            //cbPorts.Items.Add("COM3");
            //cbPorts.SelectedIndex = 0;
            foreach (string port in portlar.ToList())
            {
                cbPorts.Items.Add(port);
                cbPorts.SelectedIndex = 0;
            }

            cbBouds.Items.Add("1200");
            cbBouds.Items.Add("4800");
            cbBouds.Items.Add("9600");
            cbBouds.Items.Add("115200");
            cbBouds.Items.Add("250000");
            cbBouds.Items.Add("500000");
            cbBouds.Items.Add("1000000");
            cbBouds.Items.Add("2000000");
            cbBouds.SelectedIndex = 2;
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            if (!SP.IsOpen)
            {
                SP.PortName = cbPorts.Text;
                SP.BaudRate = Convert.ToInt32(cbBouds.Text);
                SP.Parity = Parity.None;
                SP.StopBits = StopBits.One;
                SP.DataBits = 8;
                SP.Handshake = Handshake.None;
                SP.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

                try
                {
                    SP.Open();
                    btConnect.ForeColor = Color.Cyan;
                    btConnect.Text = "Bağlantı Kes";
                    btConnect.BackColor = Color.Green;
                    cbBouds.Enabled = false;
                    cbPorts.Enabled = false;

                }
                catch (Exception)
                {
                    btConnect.ForeColor = Color.Cyan;
                    btConnect.BackColor = Color.Yellow;
                }
            }
            else
            {
                SP.Close();
                btConnect.ForeColor = Color.PaleVioletRed;
                btConnect.BackColor = Color.LightYellow;
                btConnect.Text = "Bağlan";
                cbBouds.Enabled = true;
                cbPorts.Enabled = true;
            }   
        }
        

        private  void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
                int number = System.Diagnostics.Process.GetCurrentProcess().Threads.Count;
                indata = "";
                SerialPort sp = (SerialPort)sender;
            try
            {
                indata = sp.ReadLine();
                sp.DiscardInBuffer();
                sp.DiscardOutBuffer();
            }
            catch { }

                if (indata != "") indata = indata.Replace("\r", "");
            parts = indata.Split('|');

            if (parts.Length == 8)
            {
                
                Kp = parts[1];
                Ki = parts[2];
                Kd = parts[3];
                Input = parts[4];
                Output = parts[5];
                SetPoint = parts[6];
                Sample = parts[7];

                chartXmax++;
                chartXMin = chartXmax - Ysize;

                BeginInvoke((Action)(() =>
                {
                    chart1.Series["Input"].Points.AddY(Input);
                    chart1.Series["Set"].Points.AddY(SetPoint);
                }));


                NumberFormatInfo formatProvider = new NumberFormatInfo
                {
                    NumberDecimalSeparator = "."
                };

                //if (chart1.Series["Input"].Points.Count > chartXmax-5) chart1.Series["Input"].Points.RemoveAt(0);
                chart1.ChartAreas[0].AxisX.Minimum = chartXMin;
                chart1.ChartAreas[0].AxisX.Maximum = chartXmax;
                chart1.ChartAreas[0].AxisY.Minimum = 0;
                chart1.ChartAreas[0].AxisY.Maximum = 1100;



                double Carpan = (300.0 / 255.0);
                pbOut.Height = 300 - Convert.ToInt32((Carpan * Convert.ToDouble(Output, formatProvider)));
                lbOutValue.Location = new Point(lbOutMaxV.Location.X, pbOut.Location.Y + 300 - Convert.ToInt32((Carpan * Convert.ToDouble(Output, formatProvider))));
                lbOutValue.Text = Output;
                lbReceivedKp.Text = Kp;
                lbReceivedKi.Text = Ki;
                lbReceivedKd.Text = Kd;
                lbReceivedSet.Text = SetPoint;
                lbReceivedSample.Text = Sample;
            }
        }
        

        void SPwrite()
        {
            if (double.TryParse(tbKp.Text + tbKi.Text + tbKd.Text + tbSample.Text + tbSet.Text, out ValueForTryParse) == true)
            {
                try
                {
                    SP.WriteLine(tbKp.Text + '|' + tbKi.Text + '|' + tbKd.Text + '|' + tbSet.Text + '|' + tbSample.Text + '|' + ResetVal);
                    ResetVal = "";
                }
                catch (Exception)
                {
                    MessageBox.Show("Bağlantıyı kontrol edin!");
                }
            }
            else
            {
                MessageBox.Show("Değerleri kontrol edin.");
            }

            
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            ResetVal = "ResetAt";
            SPwrite();
        }

        private void btGraphDelete_Click(object sender, EventArgs e)
        {
                chart1.Series["Input"].Points.Clear();
                chart1.Series["Set"].Points.Clear();
                chartXmax = 0;
        }

        private void tbChartYsize_ValueChanged(object sender, EventArgs e)
        {
            Ysize = tbChartYsize.Value;

            if (SP.IsOpen == false)
            {
                chartXMin = chartXmax - Ysize;
                chart1.ChartAreas[0].AxisX.Minimum = chartXMin;
                chart1.ChartAreas[0].AxisX.Maximum = chartXmax;
                chart1.Update();
            }

        }

        private void btSend_Click(object sender, EventArgs e)
        {
            SPwrite(); 
        }


    }
}
