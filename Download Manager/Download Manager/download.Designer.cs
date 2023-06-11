
namespace Download_Manager
{
    partial class download
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(download));
            this.adressLabel = new System.Windows.Forms.Label();
            this.pathLabel = new System.Windows.Forms.Label();
            this.urlInput = new System.Windows.Forms.TextBox();
            this.pathInput = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.stopBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.downloadLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // adressLabel
            // 
            this.adressLabel.AutoSize = true;
            this.adressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.adressLabel.ForeColor = System.Drawing.Color.DimGray;
            this.adressLabel.Location = new System.Drawing.Point(48, 23);
            this.adressLabel.Name = "adressLabel";
            this.adressLabel.Size = new System.Drawing.Size(56, 20);
            this.adressLabel.TabIndex = 2;
            this.adressLabel.Text = "Adres";
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pathLabel.ForeColor = System.Drawing.Color.DimGray;
            this.pathLabel.Location = new System.Drawing.Point(69, 58);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(35, 20);
            this.pathLabel.TabIndex = 3;
            this.pathLabel.Text = "Yol";
            // 
            // urlInput
            // 
            this.urlInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.urlInput.Location = new System.Drawing.Point(110, 20);
            this.urlInput.Name = "urlInput";
            this.urlInput.ReadOnly = true;
            this.urlInput.Size = new System.Drawing.Size(444, 26);
            this.urlInput.TabIndex = 4;
            // 
            // pathInput
            // 
            this.pathInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pathInput.Location = new System.Drawing.Point(110, 52);
            this.pathInput.Name = "pathInput";
            this.pathInput.Size = new System.Drawing.Size(444, 26);
            this.pathInput.TabIndex = 5;
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addBtn.ForeColor = System.Drawing.Color.White;
            this.addBtn.Image = ((System.Drawing.Image)(resources.GetObject("addBtn.Image")));
            this.addBtn.Location = new System.Drawing.Point(560, 50);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(41, 30);
            this.addBtn.TabIndex = 8;
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.stopBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.stopBtn.FlatAppearance.BorderSize = 0;
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.stopBtn.ForeColor = System.Drawing.Color.White;
            this.stopBtn.Location = new System.Drawing.Point(374, 187);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(180, 34);
            this.stopBtn.TabIndex = 9;
            this.stopBtn.Text = "Dur";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.startBtn.ForeColor = System.Drawing.Color.White;
            this.startBtn.Location = new System.Drawing.Point(110, 187);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(180, 34);
            this.startBtn.TabIndex = 10;
            this.startBtn.Text = "Başla";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(110, 100);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(444, 23);
            this.progressBar.TabIndex = 11;
            // 
            // downloadLabel
            // 
            this.downloadLabel.AutoSize = true;
            this.downloadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.downloadLabel.ForeColor = System.Drawing.Color.DimGray;
            this.downloadLabel.Location = new System.Drawing.Point(289, 137);
            this.downloadLabel.Name = "downloadLabel";
            this.downloadLabel.Size = new System.Drawing.Size(85, 20);
            this.downloadLabel.TabIndex = 12;
            this.downloadLabel.Text = "%0 İndirildi";
            // 
            // download
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(637, 252);
            this.Controls.Add(this.downloadLabel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.stopBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.pathInput);
            this.Controls.Add(this.urlInput);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.adressLabel);
            this.MaximizeBox = false;
            this.Name = "download";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "İndir";
            this.Load += new System.EventHandler(this.download_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adressLabel;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TextBox urlInput;
        private System.Windows.Forms.TextBox pathInput;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label downloadLabel;
    }
}