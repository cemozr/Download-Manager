using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Download_Manager
{
    static class App
    {
        static DownloadManagerDataSet db;
        public static DownloadManagerDataSet DB
        {
            get
            {
                if (db == null)
                    db = new DownloadManagerDataSet();
                return db;
            }
        }
    }
}
