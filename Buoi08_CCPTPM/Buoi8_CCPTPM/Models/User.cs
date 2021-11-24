using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buoi8_CCPTPM.Models
{
    public class User
    {
        protected int ID;
        protected string TenTaiKhoan;
        protected string MatKhau;

        public bool DangNhap(string tentk, string mk)
        {
            return true;
        }
    }
}
