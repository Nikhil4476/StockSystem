using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockClasses
{
    public class clsDataConnection
    {
        //connection object used to connect to the database
        SqlConnection connectionToDB = new SqlConnection();
        //data adpater used to transfer data to and from the database 
        SqlDataAdapter dataChannel = new SqlDataAdapter();
    }
    set
    {
        //set the query results 
        dataTable = value;
    }
}


