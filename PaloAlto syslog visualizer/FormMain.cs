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

        private String[] columnsHeader =
        {
            "Receive Time",
            "Source Address",
            "Destination Address",
            "NAT Source IP",
            "NAT Destination Address",
            "Rule Name",
            "Destination User",
            "Application",
            "Source Zone",
            "Destination Zone",
            "Inbound Interface",
            "Outbound Interface",
            "Sessione ID",
            "Source Port",
            "Destioantion Port",
            "NAT Source Port",
            "NAT Destionation Port",
            "Flags",
            "Protocol",
            "Action",
            "Bytes",
            "Bytes Received",
            "Bytes Sent",
            "Packets",
            "Elapsed Time",
            "Category",
            "Packets Sent",
            "Packets Received",
            "Session End Reason",
            "Action Source"
        };

        private enum searchParameter
        {
            SourceAddress,
            DestinationAddress,
            DestinationPort,
            Action,
            InboundInterface,
            RuleName
        };

        private int[] getIndexOfIndexSearchParameter(int indexDB)
        {
            int[] indexOfIndexSearchParameter = new int[Enum.GetNames(typeof(searchParameter)).Length];
            indexOfIndexSearchParameter[(int)searchParameter.SourceAddress] = Program.database[indexDB].strSourceAddress.IndexOf(textBoxSouceAddress.Text, StringComparison.CurrentCultureIgnoreCase);
            indexOfIndexSearchParameter[(int)searchParameter.DestinationAddress] = Program.database[indexDB].strDestinationAddress.IndexOf(textBoxDestinationAddress.Text, StringComparison.CurrentCultureIgnoreCase);
            indexOfIndexSearchParameter[(int)searchParameter.DestinationPort] = Program.database[indexDB].strDestinationPort.IndexOf(textBoxDestinationPort.Text, StringComparison.CurrentCultureIgnoreCase);
            indexOfIndexSearchParameter[(int)searchParameter.Action] = Program.database[indexDB].strAction.IndexOf(textBoxAction.Text, StringComparison.CurrentCultureIgnoreCase);
            indexOfIndexSearchParameter[(int)searchParameter.InboundInterface] = Program.database[indexDB].strInboundInterface.IndexOf(textBoxInboundInterface.Text, StringComparison.CurrentCultureIgnoreCase);
            indexOfIndexSearchParameter[(int)searchParameter.RuleName] = Program.database[indexDB].strRuleName.IndexOf(textBoxRuleName.Text, StringComparison.CurrentCultureIgnoreCase);
            
            return indexOfIndexSearchParameter;
        }

        private bool[] getCheckBoxCheckedSearchParameter()
        {
            bool[] checkBoxCheckedSearchParameter = new bool[Enum.GetNames(typeof(searchParameter)).Length];
            checkBoxCheckedSearchParameter[(int)searchParameter.SourceAddress] = checkBoxSouceAddress.Checked;
            checkBoxCheckedSearchParameter[(int)searchParameter.DestinationAddress] = checkBoxDestinationAddress.Checked;
            checkBoxCheckedSearchParameter[(int)searchParameter.DestinationPort] = checkBoxDestinationPort.Checked;
            checkBoxCheckedSearchParameter[(int)searchParameter.Action] = checkBoxAction.Checked;
            checkBoxCheckedSearchParameter[(int)searchParameter.InboundInterface] = checkBoxInboundInterface.Checked;
            checkBoxCheckedSearchParameter[(int)searchParameter.RuleName] = checkBoxRuleName.Checked;

            return checkBoxCheckedSearchParameter;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            lableSearchTip.Visible = false;
            DataTable dt = new DataTable();


            foreach (String column in columnsHeader)
                dt.Columns.Add(column, typeof(string));

            bool[] searchByParameter = new bool[Enum.GetNames(typeof(searchParameter)).Length]; //all false by default

            if (textBoxSouceAddress.Text != "")
                searchByParameter[(int)searchParameter.SourceAddress] = true;
            if (textBoxDestinationAddress.Text != "")
                searchByParameter[(int)searchParameter.DestinationAddress] = true;
            if (textBoxDestinationPort.Text != "")
                searchByParameter[(int)searchParameter.DestinationPort] = true;
            if (textBoxAction.Text != "")
                searchByParameter[(int)searchParameter.Action] = true;
            if (textBoxInboundInterface.Text != "")
                searchByParameter[(int)searchParameter.InboundInterface] = true;
            if (textBoxRuleName.Text != "")
                searchByParameter[(int)searchParameter.RuleName] = true;

            bool searchIsOn = false;
            foreach (int enumIndex in Enum.GetValues(typeof(searchParameter)))
                if (searchByParameter[enumIndex])
                    searchIsOn = true;

            int itemLeftToPrint = 50;
            int lastItemWrited = (int)Program.databaseIndexLastItem;
            if (lastItemWrited != -1)
            {
                bool[] checkBoxCheckedSearchParameter = getCheckBoxCheckedSearchParameter();
                for (int indexDB = lastItemWrited; indexDB > 0 && itemLeftToPrint > 0; indexDB--)
                {
                    if (searchIsOn)
                    {
                        int[] indexOfIndexSearchParameter = getIndexOfIndexSearchParameter(indexDB);

                        bool matchTheFilter = true;
                        foreach (int enumIndex in Enum.GetValues(typeof(searchParameter)))
                            if (matchTheFilter) //if it's false I don't care anymore
                                matchTheFilter = !searchByParameter[enumIndex] || (checkBoxCheckedSearchParameter[enumIndex] ? indexOfIndexSearchParameter[enumIndex] == -1 : indexOfIndexSearchParameter[enumIndex] != -1);

                        if(matchTheFilter)
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
                            int[] indexOfIndexSearchParameter = getIndexOfIndexSearchParameter(indexDB);

                            bool matchTheFilter = true;
                            foreach (int enumIndex in Enum.GetValues(typeof(searchParameter)))
                                if (matchTheFilter) //if it's false I don't care anymore
                                    matchTheFilter = !searchByParameter[enumIndex] || (checkBoxCheckedSearchParameter[enumIndex] ? indexOfIndexSearchParameter[enumIndex] == -1 : indexOfIndexSearchParameter[enumIndex] != -1);

                            if (matchTheFilter)
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

    }
}
