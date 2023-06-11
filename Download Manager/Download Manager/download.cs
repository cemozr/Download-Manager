using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Download_Manager
{
    public partial class download : Form
    {
        public download(main form)
        {
            InitializeComponent();
            _main = form;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri(this.Url);
            FileName = System.IO.Path.GetFileName(uri.AbsolutePath);
            client.DownloadFileAsync(uri, Properties.Settings.Default.Path + "/" + FileName);
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            client.CancelAsync();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Yol Seçiniz"})
            {
                if(fbd.ShowDialog() == DialogResult.OK)
                {
                    pathInput.Text = fbd.SelectedPath;
                    Properties.Settings.Default.Path = pathInput.Text;
                    Properties.Settings.Default.Save();
                }
            }
        }
        WebClient client;
        public string Url { get; set; }
        public string FileName { get; set; }
        public double FileSize { get; set; }
        public double Percentage { get; set; }
        private main _main;
        private void download_Load(object sender, EventArgs e)
        {
            client = new WebClient();
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
            urlInput.Text = Url;
            pathInput.Text = Properties.Settings.Default.Path;
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            DownloadManagerDataSet.FilesRow row = App.DB.Files.NewFilesRow();
            row.Url = Url;
            row.FileName = FileName;
            row.FileSize = (string.Format("{0:0.##} KB", FileSize / 1024));
            row.Date = DateTime.Now;
            App.DB.AcceptChanges();
            App.DB.WriteXml(string.Format("{0}/data.dat", Application.StartupPath));
            ListViewItem item = new ListViewItem(row.Id.ToString());
            item.SubItems.Add(row.Url);
            item.SubItems.Add(row.FileName);
            item.SubItems.Add(row.FileSize);
            item.SubItems.Add(row.Date.ToLongDateString());
            _main.listView1.Items.Add(item);
            this.Close();
            MessageBox.Show("İndirme Tamamlandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar.Minimum = 0;
            double receive = double.Parse(e.BytesReceived.ToString());
            FileSize = double.Parse(e.TotalBytesToReceive.ToString());
            Percentage = receive / FileSize * 100;
            downloadLabel.Text = $"İndirildi {string.Format("{0:0.##}", Percentage)}";
            progressBar.Value = int.Parse(Math.Truncate(Percentage).ToString());
            progressBar.Update();
            
           
                
            
        }
    }
}
