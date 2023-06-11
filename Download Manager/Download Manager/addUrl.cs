using System;
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
    public partial class addUrl : Form
    {
        public addUrl()
        {
            InitializeComponent();
        }
        public string Url { get; set; }
        private void addBtn_Click(object sender, EventArgs e)
        {
            this.Url = urlInput.Text;
        }
    }
}
