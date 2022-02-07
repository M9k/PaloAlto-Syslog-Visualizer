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
            lableSearchTip.Visible = false;
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

            bool searchBySourceAddress = false;
            bool searchByDestinationAddress = false;
            bool searchByDestinationPort = false;
            bool searchByAction = false;
            bool searchByInboundInterface = false;
            bool searchByRuleName = false;
            bool searchIsOn = false;

            if (textBoxSouceAddress.Text != "")
                searchBySourceAddress = true;
            if (textBoxDestinationAddress.Text != "")
                searchByDestinationAddress = true;
            if (textBoxDestinationPort.Text != "")
                searchByDestinationPort = true;
            if (textBoxAction.Text != "")
                searchByAction = true;
            if (textBoxInboundInterface.Text != "")
                searchByInboundInterface = true;
            if (textBoxRuleName.Text != "")
                searchByRuleName = true;
            if (searchBySourceAddress || searchByDestinationAddress || searchByDestinationPort ||
                searchByAction || searchByInboundInterface || searchByRuleName)
                searchIsOn = true;

            int itemLeftToPrint = 50;
            int lastItemWrited = (int)Program.databaseIndexLastItem;
            if (lastItemWrited != -1)
            {
                int indexOfSourceAddress, indexOfDestinationAddress, indexOfDestinationPort, indexOfAction, indexOfInboundInterface, indexOfRuleName;
                for (int indexDB = lastItemWrited; indexDB > 0 && itemLeftToPrint > 0; indexDB--)
                {
                    if (searchIsOn)
                    {
                        indexOfSourceAddress = Program.database[indexDB].strSourceAddress.IndexOf(textBoxSouceAddress.Text, StringComparison.CurrentCultureIgnoreCase);
                        indexOfDestinationAddress = Program.database[indexDB].strDestinationAddress.IndexOf(textBoxDestinationAddress.Text, StringComparison.CurrentCultureIgnoreCase);
                        indexOfDestinationPort = Program.database[indexDB].strDestinationPort.IndexOf(textBoxDestinationPort.Text, StringComparison.CurrentCultureIgnoreCase);
                        indexOfAction = Program.database[indexDB].strAction.IndexOf(textBoxAction.Text, StringComparison.CurrentCultureIgnoreCase);
                        indexOfInboundInterface = Program.database[indexDB].strInboundInterface.IndexOf(textBoxInboundInterface.Text, StringComparison.CurrentCultureIgnoreCase);
                        indexOfRuleName = Program.database[indexDB].strRuleName.IndexOf(textBoxRuleName.Text, StringComparison.CurrentCultureIgnoreCase);

                        if ((!searchBySourceAddress || (checkBoxSouceAddress.Checked ? indexOfSourceAddress == -1 : indexOfSourceAddress != -1)) &&
                            (!searchByDestinationAddress || (checkBoxDestinationAddress.Checked ? indexOfDestinationAddress == -1 : indexOfDestinationAddress != -1)) &&
                            (!searchByDestinationPort || (checkBoxDestinationPort.Checked ? indexOfDestinationPort == -1 : indexOfDestinationPort != -1)) &&
                            (!searchByAction || (checkBoxAction.Checked ? indexOfAction == -1 : indexOfAction != -1)) &&
                            (!searchByInboundInterface || (checkBoxInboundInterface.Checked ? indexOfInboundInterface == -1 : indexOfInboundInterface != -1)) &&
                            (!searchByRuleName || (checkBoxRuleName.Checked ? indexOfRuleName == -1 : indexOfRuleName != -1)) 
                            )
                        {
                            dt.Rows.Add(Program.database[indexDB].getAll);
                            itemLeftToPrint--;
                        }
                    }
                    else
                    {
                        dt.Rows.Add(Program.database[indexDB].getAll);
                        itemLeftToPrint--;
                    }
                }

                if (itemLeftToPrint > 0 && Program.databaseOverwrite)
                {
                    int indexDB = (int)Program.databaseSize - 1;
                    while (indexDB > lastItemWrited && itemLeftToPrint > 0)
                    {
                        if (searchIsOn)
                        {
                            indexOfSourceAddress = Program.database[indexDB].strSourceAddress.IndexOf(textBoxSouceAddress.Text, StringComparison.CurrentCultureIgnoreCase);
                            indexOfDestinationAddress = Program.database[indexDB].strDestinationAddress.IndexOf(textBoxDestinationAddress.Text, StringComparison.CurrentCultureIgnoreCase);
                            indexOfDestinationPort = Program.database[indexDB].strDestinationPort.IndexOf(textBoxDestinationPort.Text, StringComparison.CurrentCultureIgnoreCase);
                            indexOfAction = Program.database[indexDB].strAction.IndexOf(textBoxAction.Text, StringComparison.CurrentCultureIgnoreCase);
                            indexOfInboundInterface = Program.database[indexDB].strInboundInterface.IndexOf(textBoxInboundInterface.Text, StringComparison.CurrentCultureIgnoreCase);
                            indexOfRuleName = Program.database[indexDB].strRuleName.IndexOf(textBoxRuleName.Text, StringComparison.CurrentCultureIgnoreCase);

                            if ((!searchBySourceAddress || (checkBoxSouceAddress.Checked ? indexOfSourceAddress == -1 : indexOfSourceAddress != -1)) &&
                                (!searchByDestinationAddress || (checkBoxDestinationAddress.Checked ? indexOfDestinationAddress == -1 : indexOfDestinationAddress != -1)) &&
                                (!searchByDestinationPort || (checkBoxDestinationPort.Checked ? indexOfDestinationPort == -1 : indexOfDestinationPort != -1)) &&
                                (!searchByAction || (checkBoxAction.Checked ? indexOfAction == -1 : indexOfAction != -1)) &&
                                (!searchByInboundInterface || (checkBoxInboundInterface.Checked ? indexOfInboundInterface == -1 : indexOfInboundInterface != -1)) &&
                                (!searchByRuleName || (checkBoxRuleName.Checked ? indexOfRuleName == -1 : indexOfRuleName != -1))
                                )
                            {
                                dt.Rows.Add(Program.database[indexDB].getAll);
                                itemLeftToPrint--;
                            }
                        }
                        else {
                            dt.Rows.Add(Program.database[indexDB].getAll);
                            itemLeftToPrint--;
                        }
                        indexDB--;
                    }
                }
            }

            dataGridViewLogs.DataSource = dt;

            // not sortable
            foreach (DataGridViewColumn column in dataGridViewLogs.Columns)
                column.SortMode = DataGridViewColumnSortMode.NotSortable;

            // remove the empty one
            dataGridViewLogs.AllowUserToAddRows = false;

            // resize the columns
            foreach (DataGridViewColumn column in dataGridViewLogs.Columns)
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }

        private void buttonPauseStartCapture_Click(object sender, EventArgs e)
        {
            // if it's capturing -> stop it and set the button to restart it later
            if (captureStatus)
            {
                // Stop the syslog capture
                Program.StopCapture();
                buttonPauseStartCapture.Text = "Start capture";
            }
            // if it's not capturing -> start it and set the button to stop it later
            else
            {
                // Restart the syslog capture
                Program.StartCapture();
                buttonPauseStartCapture.Text = "Stop capture";
            }
            captureStatus = !captureStatus;
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.StopCapture();
            Program.StopRefresh();
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            Program.StopCapture();
            Program.resetDB();
            Program.StartCapture();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
