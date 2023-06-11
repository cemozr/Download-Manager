using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Download_Manager
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            using (settings _settings = new settings())
            {
                _settings.ShowDialog();
            }
        }

        private void urlBtn_Click(object sender, EventArgs e)
        {
            using (addUrl _addUrl = new addUrl())
            {
                if(_addUrl.ShowDialog() == DialogResult.OK)
                {
                    download _download = new download(this);
                    _download.Url = _addUrl.Url;
                    _download.Show();
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bu Kaydı Silmek İstediğine Emin Misin?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for(int i = listView1.SelectedItems.Count; i > 0; i--)
                {
                    ListViewItem item = listView1.SelectedItems[i - 1];
                    
                    listView1.Items[item.Index].Remove();
                }
                //Save
                App.DB.AcceptChanges();
                App.DB.WriteXml(string.Format("{0}/data.dat", Application.StartupPath));
            }
        }

        private void main_Load(object sender, EventArgs e)
        {
            string fileName = string.Format("{0}/data.dat", Application.StartupPath);
            if (File.Exists(fileName))
                App.DB.ReadXml(fileName);
            foreach(DownloadManagerDataSet.FilesRow row in App.DB.Files)
            {
                ListViewItem item = new ListViewItem(row.Id.ToString());
                item.SubItems.Add(row.Url);
                item.SubItems.Add(row.FileName);
                item.SubItems.Add(row.FileSize);
                item.SubItems.Add(row.Date.ToLongDateString());
                listView1.Items.Add(item);
            }
           
        }
    }
}
