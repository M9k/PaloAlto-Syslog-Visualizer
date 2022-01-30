using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaloAlto_syslog_visualizer
{
    public partial class FormMain : Form
    {
        static bool captureStatus = true;

        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            labelDebug.Text = "asdasdasd as das das da adas das das das das\nasd asd asd as das a \n asd asdasd";

            DataTable dt = new DataTable();
            dt.Columns.Add("Receive Time", typeof(string));
            dt.Columns.Add("Source Address", typeof(string));
            dt.Columns.Add("Destination Address", typeof(string));
            dt.Columns.Add("NAT Source IP", typeof(string));
            dt.Columns.Add("NAT Destination Address", typeof(string));
            dt.Columns.Add("Rule Name", typeof(string));
            dt.Columns.Add("Destination User", typeof(string));
            dt.Columns.Add("Application", typeof(string));
            dt.Columns.Add("Source Zone", typeof(string));
            dt.Columns.Add("Destination Zone", typeof(string));
            dt.Columns.Add("Inbound Interface", typeof(string));
            dt.Columns.Add("Outbound Interface", typeof(string));
            dt.Columns.Add("Sessione ID", typeof(string));
            dt.Columns.Add("Source Port", typeof(string));
            dt.Columns.Add("Destioantion Port", typeof(string));
            dt.Columns.Add("NAT Source Port", typeof(string));
            dt.Columns.Add("NAT Destionation Port", typeof(string));
            dt.Columns.Add("Flags", typeof(string));
            dt.Columns.Add("Protocol", typeof(string));
            dt.Columns.Add("Action", typeof(string));
            dt.Columns.Add("Bytes", typeof(string));
            dt.Columns.Add("Bytes Received", typeof(string));
            dt.Columns.Add("Bytes Sent", typeof(string));
            dt.Columns.Add("Packets", typeof(string));
            dt.Columns.Add("Elapsed Time", typeof(string));
            dt.Columns.Add("Category", typeof(string));
            dt.Columns.Add("Packets Sent", typeof(string));
            dt.Columns.Add("Packets Received", typeof(string));
            dt.Columns.Add("Session End Reason", typeof(string));
            dt.Columns.Add("Action Source", typeof(string));

            for (int i =0; i<50; i++)
                dt.Rows.Add(Program.database[i].getAll);
            //foreach (StructEntryLog ts in Program.database)
            //{
            //    dt.Rows.Add(ts.getAll);
            //}

            dataGridViewLogs.DataSource = dt;

        }

        private void buttonPauseStartCapture_Click(object sender, EventArgs e)
        {
            // if it's capturing -> stop it and set the button to restart it later
            if (captureStatus)
            {
                // TODO: stop the syslog capture
                buttonPauseStartCapture.Text = "Start capture";
            }
            // if it's not capturing -> start it and set the button to stop it later
            else
            {
                // TODO: restart the syslog capture
                buttonPauseStartCapture.Text = "Stop capture";
            }
            captureStatus = !captureStatus;
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.StopCapture();
        }
    }
}
