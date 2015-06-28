using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Section5DBConnection;


namespace Section5DBCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polymorphism Example
            var dbConn = new SQLConnection("abcdefgh");

            var dbCmd = new DBCommand(dbConn,"select * from tbl;");

            dbCmd.Execute();

            var dbConn2 = new OracleConnection("12345");

            var dbCmd2 = new DBCommand(dbConn2,"Select name, count(*) from tbl;");

            dbCmd2.Execute();

        }
    }
}
