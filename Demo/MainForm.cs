using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Demo
{
    public partial class MainForm : Form
    {
        private static string CONNECT = "Connect";
        private static string DISCONNECT = "Disconnect";

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitSliders();
            FillCombo();
            btnConnect.Text = CONNECT;
        }

        private void FillCombo()
        {
            cboPort.Items.Clear();
            try
            {
                cboPort.Items.AddRange(SerialPortList.GetPortNames());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cboPort.Items.Add("(Refresh)");
            }
        }

        List<Slider> sliders;

        private void InitSliders()
        {
            int i = 0;
            sliders = this.Controls.OfType<Slider>().OrderBy(x => x.TabIndex).ToList();
            foreach (var slider in sliders)
            {
                slider.Value = 128;
                slider.ServoName = ((char)('A' + i)).ToString();
                ++i;
            }
        }

        private void cboPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPort.SelectedIndex == cboPort.Items.Count - 1)
            {
                FillCombo();
                btnConnect.Enabled = false;
            }
            else if (cboPort.SelectedIndex != -1)
            {
                btnConnect.Enabled = true;
            }
        }

        ServoController sc;
        Dictionary<char, int> lastValues;
        Thread ScanThread;

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text == CONNECT)
            {
                try
                {
                    Connect();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                btnConnect.Text = DISCONNECT;
            }
            else
            {
                try
                {
                    Disconnect();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                btnConnect.Text = CONNECT;
            }
        }

        private void Disconnect()
        {
            if (ScanThread != null)
            {
                ScanThread.Abort();
            }
            if (sc != null)
            {
                try
                {
                    sc.Stop();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            sc = null;
        }

        private void Connect()
        {
            lastValues = new Dictionary<char, int>();
            foreach (var slider in sliders)
            {
                lastValues.Add(slider.ServoName[0], 128);
            }
            ScanThread = new Thread(ScanForChanges);
            sc = new ServoController(cboPort.SelectedItem.ToString());
            try
            {
                sc.Start();
            }
            catch
            {
                sc.Stop();
            }
            ScanThread.Start();
        }

        private void ScanForChanges()
        {
            while (true)
            {
                foreach (var slider in sliders)
                {
                    if (lastValues[slider.ServoName[0]] != slider.Value)
                    {
                        lastValues[slider.ServoName[0]] = slider.Value;
                        sc.AddDataToQueue(new ServoController.ServoData()
                        {
                            Servo = slider.ServoName[0],
                            Value = slider.Value
                        });
                    }
                }
                Thread.Sleep(10);
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                Disconnect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
