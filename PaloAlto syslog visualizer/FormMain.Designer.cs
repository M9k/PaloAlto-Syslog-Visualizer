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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.dataGridViewLogs = new System.Windows.Forms.DataGridView();
            this.labelSouceAddress = new System.Windows.Forms.Label();
            this.textBoxSouceAddress = new System.Windows.Forms.TextBox();
            this.buttonPauseStartCapture = new System.Windows.Forms.Button();
            this.panelLogs = new System.Windows.Forms.Panel();
            this.lableSearchTip = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxRuleName = new System.Windows.Forms.CheckBox();
            this.textBoxRuleName = new System.Windows.Forms.TextBox();
            this.labelRuleName = new System.Windows.Forms.Label();
            this.checkBoxInboundInterface = new System.Windows.Forms.CheckBox();
            this.textBoxInboundInterface = new System.Windows.Forms.TextBox();
            this.labelInboundInterface = new System.Windows.Forms.Label();
            this.checkBoxAction = new System.Windows.Forms.CheckBox();
            this.textBoxAction = new System.Windows.Forms.TextBox();
            this.labelAction = new System.Windows.Forms.Label();
            this.checkBoxDestinationPort = new System.Windows.Forms.CheckBox();
            this.textBoxDestinationPort = new System.Windows.Forms.TextBox();
            this.labelDestinationPort = new System.Windows.Forms.Label();
            this.checkBoxDestinationAddress = new System.Windows.Forms.CheckBox();
            this.checkBoxSouceAddress = new System.Windows.Forms.CheckBox();
            this.textBoxDestinationAddress = new System.Windows.Forms.TextBox();
            this.labelDestionationAddress = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusSyslog = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusBuffer = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusTotal = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).BeginInit();
            this.panelLogs.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Location = new System.Drawing.Point(1418, 9);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClean.Location = new System.Drawing.Point(1314, 9);
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
            this.dataGridViewLogs.Location = new System.Drawing.Point(3, 51);
            this.dataGridViewLogs.Name = "dataGridViewLogs";
            this.dataGridViewLogs.Size = new System.Drawing.Size(1490, 802);
            this.dataGridViewLogs.TabIndex = 3;
            // 
            // labelSouceAddress
            // 
            this.labelSouceAddress.AutoSize = true;
            this.labelSouceAddress.Location = new System.Drawing.Point(3, 6);
            this.labelSouceAddress.Name = "labelSouceAddress";
            this.labelSouceAddress.Size = new System.Drawing.Size(82, 13);
            this.labelSouceAddress.TabIndex = 4;
            this.labelSouceAddress.Text = "Souce Address:";
            // 
            // textBoxSouceAddress
            // 
            this.textBoxSouceAddress.Location = new System.Drawing.Point(6, 22);
            this.textBoxSouceAddress.Name = "textBoxSouceAddress";
            this.textBoxSouceAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxSouceAddress.TabIndex = 5;
            // 
            // buttonPauseStartCapture
            // 
            this.buttonPauseStartCapture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPauseStartCapture.Location = new System.Drawing.Point(1198, 9);
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
            this.panelLogs.Controls.Add(this.lableSearchTip);
            this.panelLogs.Controls.Add(this.panel1);
            this.panelLogs.Controls.Add(this.buttonSearch);
            this.panelLogs.Controls.Add(this.buttonClean);
            this.panelLogs.Controls.Add(this.buttonPauseStartCapture);
            this.panelLogs.Controls.Add(this.dataGridViewLogs);
            this.panelLogs.Location = new System.Drawing.Point(0, 2);
            this.panelLogs.Name = "panelLogs";
            this.panelLogs.Size = new System.Drawing.Size(1496, 856);
            this.panelLogs.TabIndex = 8;
            // 
            // lableSearchTip
            // 
            this.lableSearchTip.AutoSize = true;
            this.lableSearchTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableSearchTip.Location = new System.Drawing.Point(507, 331);
            this.lableSearchTip.Name = "lableSearchTip";
            this.lableSearchTip.Size = new System.Drawing.Size(414, 29);
            this.lableSearchTip.TabIndex = 7;
            this.lableSearchTip.Text = "Press \"Search\" to show captured data";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxRuleName);
            this.panel1.Controls.Add(this.textBoxRuleName);
            this.panel1.Controls.Add(this.labelRuleName);
            this.panel1.Controls.Add(this.checkBoxInboundInterface);
            this.panel1.Controls.Add(this.textBoxInboundInterface);
            this.panel1.Controls.Add(this.labelInboundInterface);
            this.panel1.Controls.Add(this.checkBoxAction);
            this.panel1.Controls.Add(this.textBoxAction);
            this.panel1.Controls.Add(this.labelAction);
            this.panel1.Controls.Add(this.checkBoxDestinationPort);
            this.panel1.Controls.Add(this.textBoxDestinationPort);
            this.panel1.Controls.Add(this.labelDestinationPort);
            this.panel1.Controls.Add(this.checkBoxDestinationAddress);
            this.panel1.Controls.Add(this.checkBoxSouceAddress);
            this.panel1.Controls.Add(this.textBoxDestinationAddress);
            this.panel1.Controls.Add(this.labelDestionationAddress);
            this.panel1.Controls.Add(this.labelSouceAddress);
            this.panel1.Controls.Add(this.textBoxSouceAddress);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(928, 45);
            this.panel1.TabIndex = 6;
            // 
            // checkBoxRuleName
            // 
            this.checkBoxRuleName.AutoSize = true;
            this.checkBoxRuleName.Location = new System.Drawing.Point(891, 22);
            this.checkBoxRuleName.Name = "checkBoxRuleName";
            this.checkBoxRuleName.Size = new System.Drawing.Size(29, 17);
            this.checkBoxRuleName.TabIndex = 21;
            this.checkBoxRuleName.Text = "!";
            this.checkBoxRuleName.UseVisualStyleBackColor = true;
            // 
            // textBoxRuleName
            // 
            this.textBoxRuleName.Location = new System.Drawing.Point(711, 22);
            this.textBoxRuleName.Name = "textBoxRuleName";
            this.textBoxRuleName.Size = new System.Drawing.Size(174, 20);
            this.textBoxRuleName.TabIndex = 20;
            // 
            // labelRuleName
            // 
            this.labelRuleName.AutoSize = true;
            this.labelRuleName.Location = new System.Drawing.Point(708, 6);
            this.labelRuleName.Name = "labelRuleName";
            this.labelRuleName.Size = new System.Drawing.Size(61, 13);
            this.labelRuleName.TabIndex = 19;
            this.labelRuleName.Text = "Rule name:";
            // 
            // checkBoxInboundInterface
            // 
            this.checkBoxInboundInterface.AutoSize = true;
            this.checkBoxInboundInterface.Location = new System.Drawing.Point(676, 23);
            this.checkBoxInboundInterface.Name = "checkBoxInboundInterface";
            this.checkBoxInboundInterface.Size = new System.Drawing.Size(29, 17);
            this.checkBoxInboundInterface.TabIndex = 18;
            this.checkBoxInboundInterface.Text = "!";
            this.checkBoxInboundInterface.UseVisualStyleBackColor = true;
            // 
            // textBoxInboundInterface
            // 
            this.textBoxInboundInterface.Location = new System.Drawing.Point(559, 22);
            this.textBoxInboundInterface.Name = "textBoxInboundInterface";
            this.textBoxInboundInterface.Size = new System.Drawing.Size(111, 20);
            this.textBoxInboundInterface.TabIndex = 17;
            // 
            // labelInboundInterface
            // 
            this.labelInboundInterface.AutoSize = true;
            this.labelInboundInterface.Location = new System.Drawing.Point(556, 6);
            this.labelInboundInterface.Name = "labelInboundInterface";
            this.labelInboundInterface.Size = new System.Drawing.Size(90, 13);
            this.labelInboundInterface.TabIndex = 16;
            this.labelInboundInterface.Text = "Inbound interface";
            // 
            // checkBoxAction
            // 
            this.checkBoxAction.AutoSize = true;
            this.checkBoxAction.Location = new System.Drawing.Point(524, 22);
            this.checkBoxAction.Name = "checkBoxAction";
            this.checkBoxAction.Size = new System.Drawing.Size(29, 17);
            this.checkBoxAction.TabIndex = 15;
            this.checkBoxAction.Text = "!";
            this.checkBoxAction.UseVisualStyleBackColor = true;
            // 
            // textBoxAction
            // 
            this.textBoxAction.Location = new System.Drawing.Point(418, 22);
            this.textBoxAction.Name = "textBoxAction";
            this.textBoxAction.Size = new System.Drawing.Size(100, 20);
            this.textBoxAction.TabIndex = 14;
            // 
            // labelAction
            // 
            this.labelAction.AutoSize = true;
            this.labelAction.Location = new System.Drawing.Point(415, 6);
            this.labelAction.Name = "labelAction";
            this.labelAction.Size = new System.Drawing.Size(40, 13);
            this.labelAction.TabIndex = 13;
            this.labelAction.Text = "Action:";
            // 
            // checkBoxDestinationPort
            // 
            this.checkBoxDestinationPort.AutoSize = true;
            this.checkBoxDestinationPort.Location = new System.Drawing.Point(383, 22);
            this.checkBoxDestinationPort.Name = "checkBoxDestinationPort";
            this.checkBoxDestinationPort.Size = new System.Drawing.Size(29, 17);
            this.checkBoxDestinationPort.TabIndex = 12;
            this.checkBoxDestinationPort.Text = "!";
            this.checkBoxDestinationPort.UseVisualStyleBackColor = true;
            // 
            // textBoxDestinationPort
            // 
            this.textBoxDestinationPort.Location = new System.Drawing.Point(288, 22);
            this.textBoxDestinationPort.Name = "textBoxDestinationPort";
            this.textBoxDestinationPort.Size = new System.Drawing.Size(89, 20);
            this.textBoxDestinationPort.TabIndex = 11;
            // 
            // labelDestinationPort
            // 
            this.labelDestinationPort.AutoSize = true;
            this.labelDestinationPort.Location = new System.Drawing.Point(286, 6);
            this.labelDestinationPort.Name = "labelDestinationPort";
            this.labelDestinationPort.Size = new System.Drawing.Size(90, 13);
            this.labelDestinationPort.TabIndex = 10;
            this.labelDestinationPort.Text = "Destionation port:";
            // 
            // checkBoxDestinationAddress
            // 
            this.checkBoxDestinationAddress.AutoSize = true;
            this.checkBoxDestinationAddress.Location = new System.Drawing.Point(253, 22);
            this.checkBoxDestinationAddress.Name = "checkBoxDestinationAddress";
            this.checkBoxDestinationAddress.Size = new System.Drawing.Size(29, 17);
            this.checkBoxDestinationAddress.TabIndex = 9;
            this.checkBoxDestinationAddress.Text = "!";
            this.checkBoxDestinationAddress.UseVisualStyleBackColor = true;
            // 
            // checkBoxSouceAddress
            // 
            this.checkBoxSouceAddress.AutoSize = true;
            this.checkBoxSouceAddress.Location = new System.Drawing.Point(112, 22);
            this.checkBoxSouceAddress.Name = "checkBoxSouceAddress";
            this.checkBoxSouceAddress.Size = new System.Drawing.Size(29, 17);
            this.checkBoxSouceAddress.TabIndex = 8;
            this.checkBoxSouceAddress.Text = "!";
            this.checkBoxSouceAddress.UseVisualStyleBackColor = true;
            // 
            // textBoxDestinationAddress
            // 
            this.textBoxDestinationAddress.Location = new System.Drawing.Point(147, 22);
            this.textBoxDestinationAddress.Name = "textBoxDestinationAddress";
            this.textBoxDestinationAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxDestinationAddress.TabIndex = 7;
            // 
            // labelDestionationAddress
            // 
            this.labelDestionationAddress.AutoSize = true;
            this.labelDestionationAddress.Location = new System.Drawing.Point(144, 6);
            this.labelDestionationAddress.Name = "labelDestionationAddress";
            this.labelDestionationAddress.Size = new System.Drawing.Size(110, 13);
            this.labelDestionationAddress.TabIndex = 6;
            this.labelDestionationAddress.Text = "Destionation Address:";
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
            // toolStripStatusSyslog
            // 
            this.toolStripStatusSyslog.Name = "toolStripStatusSyslog";
            this.toolStripStatusSyslog.Size = new System.Drawing.Size(77, 17);
            this.toolStripStatusSyslog.Text = "Capture is on";
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
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1496, 883);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panelLogs);
            this.Name = "FormMain";
            this.Text = "PaloAlto Syslog Visualizer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).EndInit();
            this.panelLogs.ResumeLayout(false);
            this.panelLogs.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.DataGridView dataGridViewLogs;
        private System.Windows.Forms.Label labelSouceAddress;
        private System.Windows.Forms.Button buttonPauseStartCapture;

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
        private Panel panel1;
        private Label labelDestionationAddress;
        private TextBox textBoxDestinationAddress;
        private CheckBox checkBoxAction;
        private TextBox textBoxAction;
        private Label labelAction;
        private CheckBox checkBoxDestinationPort;
        private TextBox textBoxDestinationPort;
        private Label labelDestinationPort;
        private CheckBox checkBoxDestinationAddress;
        private CheckBox checkBoxSouceAddress;
        private CheckBox checkBoxRuleName;
        private TextBox textBoxRuleName;
        private Label labelRuleName;
        private CheckBox checkBoxInboundInterface;
        private TextBox textBoxInboundInterface;
        private Label labelInboundInterface;
        private TextBox textBoxSouceAddress;
        private Label lableSearchTip;
    }
}

