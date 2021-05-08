using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stand_Anna
{
    class Bd
    {
        static public SqlConnection Conn { get; set; } = new SqlConnection(@"Data source=. \SQLEXPRESS; Initial Catalog=stand_Anna;Trusted_Connection=True;");
        static public SqlDataAdapter DTA { get; set; }
        static public SqlCommand Comando { get; set; }

    }
}
