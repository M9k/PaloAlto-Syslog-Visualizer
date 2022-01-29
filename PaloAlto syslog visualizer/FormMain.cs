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
            dt.Columns.Add("field1", typeof(string));
            dt.Columns.Add("field2", typeof(string));
            dt.Columns.Add("field3", typeof(string));
            dt.Columns.Add("field4", typeof(string));
            dt.Columns.Add("field5", typeof(string));
            dt.Columns.Add("field6", typeof(string));
            dt.Columns.Add("field7", typeof(string));
            dt.Columns.Add("field8", typeof(string));
            dt.Columns.Add("field9", typeof(string));
            dt.Columns.Add("field10", typeof(string));
            dt.Columns.Add("field11", typeof(string));
            dt.Columns.Add("field12", typeof(string));
            dt.Columns.Add("field13", typeof(string));
            dt.Columns.Add("field14", typeof(string));
            dt.Columns.Add("field15", typeof(string));
            dt.Columns.Add("field16", typeof(string));
            dt.Columns.Add("field17", typeof(string));
            dt.Columns.Add("field18", typeof(string));
            dt.Columns.Add("field19", typeof(string));
            dt.Columns.Add("field20", typeof(string));
            dt.Columns.Add("field21", typeof(string));
            dt.Columns.Add("field22", typeof(string));
            dt.Columns.Add("field23", typeof(string));
            dt.Columns.Add("field24", typeof(string));
            dt.Columns.Add("field25", typeof(string));
            dt.Columns.Add("field26", typeof(string));
            dt.Columns.Add("field27", typeof(string));
            dt.Columns.Add("field28", typeof(string));
            dt.Columns.Add("field29", typeof(string));
            dt.Columns.Add("field30", typeof(string));

            for (int i =0; i<50; i++)
                dt.Rows.Add(Program.database[i].getAll);
            //foreach (StructEntryLog ts in Program.database)
            //{
            //    dt.Rows.Add(ts.getAll);
            //}

            dataGridView1.DataSource = dt;

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
