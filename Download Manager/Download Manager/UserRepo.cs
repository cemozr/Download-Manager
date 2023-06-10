using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Download_Manager
{
    public class UserRepo : IUserRepo
    {
        public async Task<bool> Insert(User user)
        {
            using(IDbConnection db=new SqlConnection(AppHelper.ConnectionString))
            {
                var result = await db.ExecuteAsync(Download_Manager.Properties.Resources.InsertUser, new { Username = user.Username, Password = user.Password });
                return result > 0;
            }
        }
    }
}
