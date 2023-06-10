using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Download_Manager
{
    public interface IUserRepo
    {
        Task<bool> Insert(User user);
    }
}
