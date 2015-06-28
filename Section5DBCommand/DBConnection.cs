using System;

namespace Section5DBConnection
{
    abstract class DBConnection
    {
        //fields
        private string _connectionString;

        //auto implemented properties
        public TimeSpan Timeout { get; set; }
        public bool ConnectionOpen { get; protected set; }

        //properties
       public string ConnectionString
        {
             get
            {
                return this._connectionString;
            }

             set
            {
                if ((value == null) || (value == ""))
                 {
                      throw new InvalidOperationException("Connection string cannot be null or empty string");
                }
               else
                {
                     this._connectionString = value;
                }
            }
        }

        //constructors

        protected DBConnection(string connStr)
        {
            this.ConnectionString = connStr;
            this.ConnectionOpen = false;
        }

        //methods
        public abstract void OpenDBConnection();

        public abstract void CloseDBConnection();

    }
}
