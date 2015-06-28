using System;

namespace Section5DBConnection
{
    class SQLConnection
            :DBConnection
    {

        //constructor

        public SQLConnection(string connStr)
            :base(connStr)
        {
            
        }
        
        //methods
        public override void OpenDBConnection()
        {
            if (this.ConnectionOpen)
            {
                throw new InvalidOperationException("Cant open an already open SQL Connection");
            }

            this.ConnectionOpen = true;
            Console.WriteLine( "Open the SQL DB Connection");
        }

        public override void CloseDBConnection()
        {
            if (!this.ConnectionOpen)
            {
                throw new InvalidOperationException("Cant close an already close SQLConnection");
            }

            this.ConnectionOpen = false;
            Console.WriteLine( "Close the SQL DB Connection");
        }
    }
}
