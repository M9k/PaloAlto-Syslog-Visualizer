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
        static Thread receiveThread;
        static FormMain formMain;
        static UdpClient udpListener;
        static public StructEntryLog[] database;

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

            Application.Run(formMain);
        }


        internal static void StartCapture()
        {

            // StructEntryLog test = new StructEntryLog("a","b","c", "a", "b", "c", "a", "b", "c", "a", "b", "c", "a", "b", "c", "a", "b", "c", "a", "b", "c", "a", "b", "c", "a", "b", "c", "a", "b", "c");

            database = new StructEntryLog[1000000];
            for (int i = 0; i < database.Length; i++)
                database[i] = new StructEntryLog("a", "b", "c", "a", "b", "c", "a", "b", "c", "a", "b", "c", "a", "b", "c", "a", "b", "c", "a", "b", "c", "a", "b", "c", "a", "b", "c", "a", "b", "c");

            receiveThread = new Thread(ThreadReceive);
            receiveThread.Start();
        }

        internal static void StopCapture()
        {
            receiveThread.Abort(new object());
            udpListener.Close();
        }

        public static void ThreadReceive()
        {
            IPEndPoint anyIP = new IPEndPoint(IPAddress.Any, 0);
            udpListener = new UdpClient(514);
            byte[] bReceive;
            string sReceive;
            string sourceIP;

            formMain.SetLabelDebug("start capture");

            while (true)
            {
                try
                {
                    bReceive = udpListener.Receive(ref anyIP);
                    /* Convert incoming data from bytes to ASCII */
                    sReceive = Encoding.ASCII.GetString(bReceive);
                    /* Get the IP of the device sending the syslog */
                    sourceIP = anyIP.Address.ToString();
                    //new Thread(new logHandler(sourceIP, sReceive).handleLog).Start();
                    // TODO: Faccio con un nuovo thread che aggiorna l'interfaccia o no?
                    new Thread(() => { formMain.SetLabelDebug(sReceive); }).Start();
                    /* Start a new thread to handle received syslog event */
                }
                catch (Exception ex) { formMain.SetLabelDebug(ex.ToString()); }
            }
        }
    }
}