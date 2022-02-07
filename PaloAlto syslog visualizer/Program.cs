using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaloAlto_syslog_visualizer
{
    internal static class Program
    {
        static Thread receiveThread, statusRefresh;
        static FormMain formMain;
        static UdpClient udpListener;
        static public StructEntryLog[] database;
        static public uint databaseSize = 50000;
        static public int databaseIndexLastItem = -1;
        static public uint databaseTotalWrite = 0;
        static public bool databaseOverwrite = false;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formMain = new FormMain();

            StartCapture();
            StartStatusRefresh();

            Application.Run(formMain);
        }

        internal static void resetDB()
        {
            databaseIndexLastItem = -1;
            databaseTotalWrite = 0;
            databaseOverwrite = false;
        }

        internal static void StartCapture()
        {
            database = new StructEntryLog[databaseSize];
            // create a fake entry - for initial testing
            // StructEntryLog test = new StructEntryLog("a","b","c", "a", "b", "c", "a", "b", "c", "a", "b", "c", "a", "b", "c", "a", "b", "c", "a", "b", "c", "a", "b", "c", "a", "b", "c", "a", "b", "c");

            // use fake data - for initial testing
            //for (int i = 0; i < databaseSize; i++)
            //    database[i] = new StructEntryLog("a", "b", "c", "a", "b", "c", "a", "b", "c", "a", "b", "c", "a", "b", "c", "a", "b", "c", "a", "b", "c", "a", "b", "c", "a", "b", "c", "a", "b", "c");

            receiveThread = new Thread(ThreadReceive);
            receiveThread.Start();
            formMain.SetCaptureStatus(true);
        }

        internal static void StartStatusRefresh()
        {
            statusRefresh = new Thread(ThreadRefresh);
            statusRefresh.Start();
        }

        internal static void StopCapture()
        {
            receiveThread.Abort(new object());
            udpListener.Close();
            formMain.SetCaptureStatus(false);
        }
        internal static void StopRefresh()
        {
            statusRefresh.Abort(new object());
        }

        public static void ThreadRefresh()
        {
            while(true)
            {
                Thread.Sleep(1000);
                if (databaseIndexLastItem > -1)
                    formMain.SetStatusValues((uint)databaseIndexLastItem+1, databaseTotalWrite);
                else
                    formMain.SetStatusValues(0, databaseTotalWrite);
            }
        }

        public static void ThreadReceive()
        {
            IPEndPoint anyIP = new IPEndPoint(IPAddress.Any, 0);
            udpListener = new UdpClient(514);
            byte[] bReceive;
            string sReceive;
            string sourceIP;

            while (true)
            {
                try
                {
                    bReceive = udpListener.Receive(ref anyIP);
                    sReceive = Encoding.ASCII.GetString(bReceive);
                    sourceIP = anyIP.Address.ToString();

                    string[] receivedData = sReceive.Split(',');

                    databaseIndexLastItem++;
                    databaseTotalWrite++;

                    database[databaseIndexLastItem].strAction = receivedData[30];
                    database[databaseIndexLastItem].strActionSource = receivedData[53];
                    database[databaseIndexLastItem].strApplication = receivedData[14];
                    database[databaseIndexLastItem].strBytes = receivedData[31];
                    database[databaseIndexLastItem].strBytesReceived = receivedData[32];
                    database[databaseIndexLastItem].strBytesSent = receivedData[33];
                    database[databaseIndexLastItem].strCategory = receivedData[37];
                    database[databaseIndexLastItem].strDentinationZone = receivedData[17];
                    database[databaseIndexLastItem].strDestinationAddress = receivedData[8];
                    database[databaseIndexLastItem].strDestinationPort = receivedData[25];
                    database[databaseIndexLastItem].strElapsedTime = receivedData[36];
                    database[databaseIndexLastItem].strFlags = receivedData[28];
                    database[databaseIndexLastItem].strInboundInterface = receivedData[18];
                    database[databaseIndexLastItem].strNatDestinationIP = receivedData[8];
                    database[databaseIndexLastItem].strNATDestinationPort = receivedData[10];
                    database[databaseIndexLastItem].strNATSourceIP = receivedData[9];
                    database[databaseIndexLastItem].strNATSourcePort = receivedData[26];
                    database[databaseIndexLastItem].strOutboundInterface = receivedData[19];
                    database[databaseIndexLastItem].strPackets = receivedData[34];
                    database[databaseIndexLastItem].strPacketsReceived = receivedData[45];
                    database[databaseIndexLastItem].strPacketsSent = receivedData[44];
                    database[databaseIndexLastItem].strProtocol = receivedData[29];
                    database[databaseIndexLastItem].strReceiveTime = receivedData[1];
                    database[databaseIndexLastItem].strRuleName = receivedData[11];
                    database[databaseIndexLastItem].strSessionEndReason = receivedData[46];
                    database[databaseIndexLastItem].strSessionID = receivedData[22];
                    database[databaseIndexLastItem].strSourceAddress = receivedData[7];
                    database[databaseIndexLastItem].strSourcePort = receivedData[24];
                    database[databaseIndexLastItem].strSourceUser = receivedData[13];
                    database[databaseIndexLastItem].strSourceZone = receivedData[16];

                    if (databaseIndexLastItem == databaseSize - 1)
                    {
                        databaseIndexLastItem = 0;
                        databaseOverwrite = true;
                    }

                }
                catch (Exception)
                {
                    ;
                }
            }
        }
    }
}