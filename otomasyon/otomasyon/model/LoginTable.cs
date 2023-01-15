using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otomasyon.model
{
    internal class LoginTable
    {
        public int id { get; set; }
        public string ka { get; set; }
        public string sifre { get; set; }
        public string yetki { get; set; }
        public string email { get; set; }
        public string guvenliksoru { get; set; }
        public string guvenliksoruCevabı { get; set; }
        public string bolge { get; set; }

    }
}
