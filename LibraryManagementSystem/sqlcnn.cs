using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    class sqlcnn
    {
        //public string cnn = "Data Source=Tani;Initial Catalog=iControl;Integrated Security=True";
        public static SqlConnection getConnection()
        {
            SqlConnection cnn = new SqlConnection("Data Source=Tani;Initial Catalog=LMS;Integrated Security=True");
            return cnn;
        }
    }
}
