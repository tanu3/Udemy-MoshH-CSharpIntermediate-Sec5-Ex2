using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Section5DBConnection;

namespace Section5DBCommand
{
    class DBCommand
    {
        //fields

        private string _sqlCommand;
        private DBConnection _dbConnection;

        //properties

        public string SqlCommand
        {
            get { return this._sqlCommand; }

            set
            {
                if ((value == null) || (value == ""))
                {
                    throw new InvalidOperationException("cant hae an empty or null command");
                }
                else
                {
                    this._sqlCommand = value;
                }
             }
        }

        //constructor
        public DBCommand(DBConnection dbConn, string cmd)
        {
            if (dbConn == null)
            {
                throw new InvalidOperationException("DB Connection cannot be null");
            }

            this._dbConnection = dbConn;

            this.SqlCommand = cmd;

        }

        //method

        public void Execute()
        {
            this._dbConnection.OpenDBConnection();

            Console.WriteLine( "Running instruction {0} ", this.SqlCommand);

            this._dbConnection.CloseDBConnection();
        }

    }
}
