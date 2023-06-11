
namespace Download_Manager
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.pathLabel = new System.Windows.Forms.Label();
            this.pathInput = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.browseBtn = new System.Windows.Forms.Button();
            this.savePathBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pathLabel.ForeColor = System.Drawing.Color.DimGray;
            this.pathLabel.Location = new System.Drawing.Point(24, 37);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(49, 20);
            this.pathLabel.TabIndex = 0;
            this.pathLabel.Text = "Dizin";
            // 
            // pathInput
            // 
            this.pathInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pathInput.Location = new System.Drawing.Point(79, 34);
            this.pathInput.Name = "pathInput";
            this.pathInput.Size = new System.Drawing.Size(439, 26);
            this.pathInput.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // browseBtn
            // 
            this.browseBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.browseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseBtn.FlatAppearance.BorderSize = 0;
            this.browseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.browseBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.browseBtn.Image = ((System.Drawing.Image)(resources.GetObject("browseBtn.Image")));
            this.browseBtn.Location = new System.Drawing.Point(524, 34);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(47, 26);
            this.browseBtn.TabIndex = 4;
            this.browseBtn.UseVisualStyleBackColor = false;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // savePathBtn
            // 
            this.savePathBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(178)))), ((int)(((byte)(255)))));
            this.savePathBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savePathBtn.FlatAppearance.BorderSize = 0;
            this.savePathBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savePathBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.savePathBtn.ForeColor = System.Drawing.Color.White;
            this.savePathBtn.Location = new System.Drawing.Point(386, 66);
            this.savePathBtn.Name = "savePathBtn";
            this.savePathBtn.Size = new System.Drawing.Size(132, 34);
            this.savePathBtn.TabIndex = 5;
            this.savePathBtn.Text = "Kaydet";
            this.savePathBtn.UseVisualStyleBackColor = false;
            this.savePathBtn.Click += new System.EventHandler(this.savePathBtn_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(619, 117);
            this.Controls.Add(this.savePathBtn);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.pathInput);
            this.Controls.Add(this.pathLabel);
            this.MaximizeBox = false;
            this.Name = "settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ayarlar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.TextBox pathInput;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.Button savePathBtn;
    }
}