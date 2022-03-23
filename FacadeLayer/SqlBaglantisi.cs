using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FacadeLayer
{
    public class SqlBaglantisi
    {
        public static SqlConnection baglanti =
            new SqlConnection(@"Data Source=DESKTOP-O3DVRF8\SQLEXPRESS;Initial Catalog=TBLPROJECTMANAGMENT;Integrated Security=True");
    }
}
