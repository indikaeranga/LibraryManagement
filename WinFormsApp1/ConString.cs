using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace WinFormsApp1
{
    internal class ConString
    {
        public string connectionstring()
        {
            string constr = @"Data Source=.\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";
            return constr;
        }
        public string displayTime()
        {
            string ti = DateTime.Now.ToString("HH:mm  tt");

            return DateTime.Now.ToString("yyyy-MM-dd \n") + ti;
        }
    }
}
