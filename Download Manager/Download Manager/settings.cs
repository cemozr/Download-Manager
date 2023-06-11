﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Download_Manager
{
    public partial class settings : Form
    {
        public settings()
        {
            InitializeComponent();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() {Description="Yolu seçiniz" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                    pathInput.Text = fbd.SelectedPath;
            }

        }

        private void savePathBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(pathInput.Text))
            {
                Properties.Settings.Default.Path = pathInput.Text;
                Properties.Settings.Default.Save();
                this.Close();
            }
            else
                MessageBox.Show("Lütfen Yolu Giriniz!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
