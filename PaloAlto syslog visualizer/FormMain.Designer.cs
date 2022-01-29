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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelSouceAddress = new System.Windows.Forms.Label();
            this.textBoxSouceAddress = new System.Windows.Forms.TextBox();
            this.labelNota = new System.Windows.Forms.Label();
            this.buttonPauseStartCapture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDebug
            // 
            this.labelDebug.AutoSize = true;
            this.labelDebug.Location = new System.Drawing.Point(50, 29);
            this.labelDebug.Name = "labelDebug";
            this.labelDebug.Size = new System.Drawing.Size(61, 13);
            this.labelDebug.TabIndex = 0;
            this.labelDebug.Text = "labelDebug";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(1096, 12);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 1;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(1015, 12);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(75, 23);
            this.buttonClean.TabIndex = 2;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 386);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(962, 257);
            this.dataGridView1.TabIndex = 3;
            // 
            // labelSouceAddress
            // 
            this.labelSouceAddress.AutoSize = true;
            this.labelSouceAddress.Location = new System.Drawing.Point(181, 344);
            this.labelSouceAddress.Name = "labelSouceAddress";
            this.labelSouceAddress.Size = new System.Drawing.Size(82, 13);
            this.labelSouceAddress.TabIndex = 4;
            this.labelSouceAddress.Text = "Souce Address:";
            // 
            // textBoxSouceAddress
            // 
            this.textBoxSouceAddress.Location = new System.Drawing.Point(184, 360);
            this.textBoxSouceAddress.Name = "textBoxSouceAddress";
            this.textBoxSouceAddress.Size = new System.Drawing.Size(100, 20);
            this.textBoxSouceAddress.TabIndex = 5;
            // 
            // labelNota
            // 
            this.labelNota.AutoSize = true;
            this.labelNota.Location = new System.Drawing.Point(12, 766);
            this.labelNota.Name = "labelNota";
            this.labelNota.Size = new System.Drawing.Size(245, 13);
            this.labelNota.TabIndex = 6;
            this.labelNota.Text = "Menu in basso con lo stato del demone di cattura?";
            // 
            // buttonPauseStartCapture
            // 
            this.buttonPauseStartCapture.Location = new System.Drawing.Point(879, 12);
            this.buttonPauseStartCapture.Name = "buttonPauseStartCapture";
            this.buttonPauseStartCapture.Size = new System.Drawing.Size(110, 23);
            this.buttonPauseStartCapture.TabIndex = 7;
            this.buttonPauseStartCapture.Text = "Stop capture";
            this.buttonPauseStartCapture.UseVisualStyleBackColor = true;
            this.buttonPauseStartCapture.Click += new System.EventHandler(this.buttonPauseStartCapture_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 788);
            this.Controls.Add(this.buttonPauseStartCapture);
            this.Controls.Add(this.labelNota);
            this.Controls.Add(this.textBoxSouceAddress);
            this.Controls.Add(this.labelSouceAddress);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.labelDebug);
            this.Name = "FormMain";
            this.Text = "PaloAlto Syslog Visualizer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDebug;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelSouceAddress;
        private System.Windows.Forms.TextBox textBoxSouceAddress;
        private System.Windows.Forms.Label labelNota;
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
    }
}

