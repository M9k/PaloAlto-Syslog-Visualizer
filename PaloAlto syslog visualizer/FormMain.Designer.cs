using System.Windows.Forms;

namespace PaloAlto_syslog_visualizer
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDebug = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.dataGridViewLogs = new System.Windows.Forms.DataGridView();
            this.labelSouceAddress = new System.Windows.Forms.Label();
            this.textBoxSouceAddress = new System.Windows.Forms.TextBox();
            this.buttonPauseStartCapture = new System.Windows.Forms.Button();
            this.panelLogs = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusBuffer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusTotal = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusSyslog = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).BeginInit();
            this.panelLogs.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDebug
            // 
            this.labelDebug.AutoSize = true;
            this.labelDebug.Location = new System.Drawing.Point(12, 762);
            this.labelDebug.Name = "labelDebug";
            this.labelDebug.Size = new System.Drawing.Size(61, 13);
            this.labelDebug.TabIndex = 0;
            this.labelDebug.Text = "labelDebug";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(1409, 12);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(1328, 12);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(75, 23);
            this.buttonClean.TabIndex = 2;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // dataGridViewLogs
            // 
            this.dataGridViewLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLogs.Location = new System.Drawing.Point(3, 65);
            this.dataGridViewLogs.Name = "dataGridViewLogs";
            this.dataGridViewLogs.Size = new System.Drawing.Size(1466, 650);
            this.dataGridViewLogs.TabIndex = 3;
            // 
            // labelSouceAddress
            // 
            this.labelSouceAddress.AutoSize = true;
            this.labelSouceAddress.Location = new System.Drawing.Point(151, 14);
            this.labelSouceAddress.Name = "labelSouceAddress";
            this.labelSouceAddress.Size = new System.Drawing.Size(82, 13);
            this.labelSouceAddress.TabIndex = 4;
            this.labelSouceAddress.Text = "Souce Address:";
            // 
            // textBoxSouceAddress
            // 
            this.textBoxSouceAddress.Location = new System.Drawing.Point(154, 30);
            this.textBoxSouceAddress.Name = "textBoxSouceAddress";
            this.textBoxSouceAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxSouceAddress.TabIndex = 5;
            // 
            // buttonPauseStartCapture
            // 
            this.buttonPauseStartCapture.Location = new System.Drawing.Point(1189, 12);
            this.buttonPauseStartCapture.Name = "buttonPauseStartCapture";
            this.buttonPauseStartCapture.Size = new System.Drawing.Size(110, 23);
            this.buttonPauseStartCapture.TabIndex = 7;
            this.buttonPauseStartCapture.Text = "Stop capture";
            this.buttonPauseStartCapture.UseVisualStyleBackColor = true;
            this.buttonPauseStartCapture.Click += new System.EventHandler(this.buttonPauseStartCapture_Click);
            // 
            // panelLogs
            // 
            this.panelLogs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelLogs.Controls.Add(this.dataGridViewLogs);
            this.panelLogs.Controls.Add(this.textBoxSouceAddress);
            this.panelLogs.Controls.Add(this.labelSouceAddress);
            this.panelLogs.Location = new System.Drawing.Point(12, 41);
            this.panelLogs.Name = "panelLogs";
            this.panelLogs.Size = new System.Drawing.Size(1472, 718);
            this.panelLogs.TabIndex = 8;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusSyslog,
            this.toolStripStatusBuffer,
            this.toolStripStatusTotal});
            this.statusStrip1.Location = new System.Drawing.Point(0, 861);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1496, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusBuffer
            // 
            this.toolStripStatusBuffer.Name = "toolStripStatusBuffer";
            this.toolStripStatusBuffer.Size = new System.Drawing.Size(56, 17);
            this.toolStripStatusBuffer.Text = "Buffer: 0/";
            // 
            // toolStripStatusTotal
            // 
            this.toolStripStatusTotal.Name = "toolStripStatusTotal";
            this.toolStripStatusTotal.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusTotal.Text = "Total logs: 0";
            // 
            // toolStripStatusSyslog
            // 
            this.toolStripStatusSyslog.Name = "toolStripStatusSyslog";
            this.toolStripStatusSyslog.Size = new System.Drawing.Size(77, 17);
            this.toolStripStatusSyslog.Text = "Capture is on";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 883);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelLogs);
            this.Controls.Add(this.buttonPauseStartCapture);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.labelDebug);
            this.Name = "FormMain";
            this.Text = "PaloAlto Syslog Visualizer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).EndInit();
            this.panelLogs.ResumeLayout(false);
            this.panelLogs.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDebug;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.DataGridView dataGridViewLogs;
        private System.Windows.Forms.Label labelSouceAddress;
        private System.Windows.Forms.TextBox textBoxSouceAddress;
        private System.Windows.Forms.Button buttonPauseStartCapture;

        public void SetLabelDebug(string text)
        {
            // using labelDebug after destroy the form (closing the app) it try to access a destroyed form
            try
            {
                this.Invoke(new MethodInvoker(delegate { labelDebug.Text = text; }));
            }
            catch
            {
                ;
            }
        }

        public void SetStatusValues(uint buffer, uint total)
        {
            this.toolStripStatusBuffer.Text = "Buffer: "+buffer+"/" + Program.databaseSize;
            this.toolStripStatusTotal.Text = "Total logs: "+total;
        }
        public void SetCaptureStatus(bool capturing)
        {
            if (capturing)
                this.toolStripStatusSyslog.Text = "Capture is on";
            else
                this.toolStripStatusSyslog.Text = "Capture is off";
        }

        private Panel panelLogs;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusBuffer;
        private ToolStripStatusLabel toolStripStatusTotal;
        private ToolStripStatusLabel toolStripStatusSyslog;
    }
}

