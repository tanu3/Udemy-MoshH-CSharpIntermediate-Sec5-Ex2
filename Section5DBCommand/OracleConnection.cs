using System;

namespace Section5DBConnection
{
    internal class OracleConnection
        :DBConnection
    {

        //constructor

        public OracleConnection(string connStr)
            :base(connStr)
        {
            
        }
        
        //methods
        public override void OpenDBConnection()
        {
            if (this.ConnectionOpen)
            {
                throw new InvalidOperationException("Cant open an already open Oracle Connection");
            }

            this.ConnectionOpen = true;
            Console.WriteLine( "Open the Oracle DB Connection");
        }

        public override void CloseDBConnection()
        {
            if (!this.ConnectionOpen)
            {
                throw new InvalidOperationException("Cant close an already close Oracle Connection");
            }

            this.ConnectionOpen = false;
            Console.WriteLine( "Close the Oracle DB Connection");
        }
    }
}
