using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Proje_Hastahane
{
    class sqlbaglantisi
    {
        public SqlConnection Baglanti()
        {
            SqlConnection baglansan = new SqlConnection("Data Source=semiramis;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
            baglansan.Open();
            return baglansan;
             


        }


    }
}
