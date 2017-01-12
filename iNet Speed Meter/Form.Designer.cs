namespace iNet_Speed_Meter
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.labelUpload = new System.Windows.Forms.Label();
            this.textBoxUpload = new System.Windows.Forms.TextBox();
            this.textBoxDownload = new System.Windows.Forms.TextBox();
            this.labelDownload = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.textBoxConnectionType = new System.Windows.Forms.TextBox();
            this.labelConnectionType = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelUpload
            // 
            this.labelUpload.AutoSize = true;
            this.labelUpload.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelUpload.Location = new System.Drawing.Point(12, 64);
            this.labelUpload.Name = "labelUpload";
            this.labelUpload.Size = new System.Drawing.Size(46, 15);
            this.labelUpload.TabIndex = 2;
            this.labelUpload.Text = "Upload";
            // 
            // textBoxUpload
            // 
            this.textBoxUpload.BackColor = System.Drawing.Color.White;
            this.textBoxUpload.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUpload.Location = new System.Drawing.Point(15, 82);
            this.textBoxUpload.Name = "textBoxUpload";
            this.textBoxUpload.ReadOnly = true;
            this.textBoxUpload.Size = new System.Drawing.Size(225, 21);
            this.textBoxUpload.TabIndex = 3;
            this.textBoxUpload.Text = "0.0 Bytes/s";
            // 
            // textBoxDownload
            // 
            this.textBoxDownload.BackColor = System.Drawing.Color.White;
            this.textBoxDownload.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDownload.Location = new System.Drawing.Point(15, 133);
            this.textBoxDownload.Name = "textBoxDownload";
            this.textBoxDownload.ReadOnly = true;
            this.textBoxDownload.Size = new System.Drawing.Size(225, 21);
            this.textBoxDownload.TabIndex = 5;
            this.textBoxDownload.Text = "0.0 Bytes/s";
            // 
            // labelDownload
            // 
            this.labelDownload.AutoSize = true;
            this.labelDownload.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDownload.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelDownload.Location = new System.Drawing.Point(12, 115);
            this.labelDownload.Name = "labelDownload";
            this.labelDownload.Size = new System.Drawing.Size(63, 15);
            this.labelDownload.TabIndex = 4;
            this.labelDownload.Text = "Download";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorkerDoWork);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // textBoxConnectionType
            // 
            this.textBoxConnectionType.BackColor = System.Drawing.Color.White;
            this.textBoxConnectionType.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnectionType.Location = new System.Drawing.Point(15, 31);
            this.textBoxConnectionType.Name = "textBoxConnectionType";
            this.textBoxConnectionType.ReadOnly = true;
            this.textBoxConnectionType.Size = new System.Drawing.Size(225, 21);
            this.textBoxConnectionType.TabIndex = 1;
            this.textBoxConnectionType.Text = "Not Available";
            // 
            // labelConnectionType
            // 
            this.labelConnectionType.AutoSize = true;
            this.labelConnectionType.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnectionType.ForeColor = System.Drawing.Color.Indigo;
            this.labelConnectionType.Location = new System.Drawing.Point(12, 13);
            this.labelConnectionType.Name = "labelConnectionType";
            this.labelConnectionType.Size = new System.Drawing.Size(100, 15);
            this.labelConnectionType.TabIndex = 0;
            this.labelConnectionType.Text = "Connection Type";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 171);
            this.Controls.Add(this.textBoxConnectionType);
            this.Controls.Add(this.labelConnectionType);
            this.Controls.Add(this.textBoxDownload);
            this.Controls.Add(this.labelDownload);
            this.Controls.Add(this.textBoxUpload);
            this.Controls.Add(this.labelUpload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "iNet Speed Meter";
            this.Load += new System.EventHandler(this.FormLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConnectionType;
        private System.Windows.Forms.Label labelUpload;
        private System.Windows.Forms.Label labelDownload;
        private System.Windows.Forms.TextBox textBoxConnectionType;
        private System.Windows.Forms.TextBox textBoxUpload;
        private System.Windows.Forms.TextBox textBoxDownload;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Timer timer;
    }
}