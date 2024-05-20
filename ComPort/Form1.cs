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

namespace ComPort
{
    public partial class Form1 : Form
    {
        string dataOUT;
        string sendWith;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            CBoxCOMPORT.Items.AddRange(ports);

            btnOpen.Enabled = true;
            btnClose.Enabled = false;

            chBoxDtrEnable.Checked = false;
            serialPort1.DtrEnable = false;
            chBoxRtsEnable.Checked = false;
            serialPort1.RtsEnable = false;

            btnSendData.Enabled = false;

            chBoxWriteLine.Checked = false;
            chBoxWrite.Checked = true;
            sendWith = "Write";
        }

        private void CBoxCOMPORT_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = CBoxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(CBoxBAUDRATE.Text);
                serialPort1.DataBits = Convert.ToInt32(CBoxDATABITS.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), CBoxSTOPBITS.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), CBoxPARITYBITS.Text);

                serialPort1.Open();
                progressBar1.Value = 100;
                btnOpen.Enabled = false;
                btnClose.Enabled = true;
                lblStatusCom.Text = "ON";

            }
            catch ( Exception err )
            {
                MessageBox.Show( err.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                btnOpen.Enabled = true;
                btnClose.Enabled = false;
                lblStatusCom.Text = "OFF";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
                btnOpen.Enabled = true;
                btnClose.Enabled = false;

                lblStatusCom.Text = "OFF";
            }
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                dataOUT = tBoxDataOut.Text;
                if (sendWith == "WriteLine")
                {
                    serialPort1.WriteLine(dataOUT);
                }
                else if (sendWith == "Write")
                {
                    serialPort1.Write(dataOUT);
                }
            }
        }

        private void chBoxDtrEnable_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxDtrEnable.Checked)
            {
                serialPort1.DtrEnable = true;
            }
            else
            {
                serialPort1.DtrEnable = false;
            }
        }

        private void chBoxRtsEnable_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxRtsEnable.Checked)
            {
                serialPort1.RtsEnable = true;
            }
            else
            {
                serialPort1.RtsEnable = false;
            }
        }

        private void btnClearDataOut_Click(object sender, EventArgs e)
        {
            if ( tBoxDataOut.Text != "")
            {
                tBoxDataOut.Text = "";
            }
        }

        private void tBoxDataOut_TextChanged(object sender, EventArgs e)
        {
            int dataOutLength = tBoxDataOut.TextLength;
            lblDataOutLength.Text = string.Format("{0:00}", dataOutLength);

            if(chBoxUsingEnter.Checked)
            {
                tBoxDataOut.Text = tBoxDataOut.Text.Replace(Environment.NewLine, "");
            }
        }

        private void chBoxUsingButton_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxUsingButton.Checked)
            {
                btnSendData.Enabled = true;
            }
            else
            {
                btnSendData.Enabled = false;
            }
        }

        private void tBoxDataOut_KeyDown(object sender, KeyEventArgs e)
        {
            if(chBoxUsingEnter.Checked)
            {
                if(e.KeyCode == Keys.Enter)
                {
                    if (serialPort1.IsOpen)
                    {
                        dataOUT = tBoxDataOut.Text;
                        if (sendWith == "WriteLine")
                        {
                            serialPort1.WriteLine(dataOUT);
                        }
                        else if (sendWith == "Write")
                        {
                            serialPort1.Write(dataOUT);
                        }
                    }
                }
            }
        }

        private void chBoxWriteLine_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxWriteLine.Checked)
            {
                sendWith = "WriteLine";
                chBoxWrite.Checked = false;
                chBoxWriteLine.Checked = true;
            }
        }

        private void chBoxWrite_CheckedChanged(object sender, EventArgs e)
        {
            if(chBoxWrite.Checked)
            {
                sendWith = "Write";
                chBoxWrite.Checked = true;
                chBoxWriteLine.Checked = false;
            }
        }
    }
}
