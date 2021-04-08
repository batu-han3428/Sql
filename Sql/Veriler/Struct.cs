using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace Sql
{
    struct Veri
    {
         string server;
         string name;
         string password;

        ServerConnection _ServerConnection;
        Server _server;
    
        public void getServerConnection(string a)
        {
            _ServerConnection = new ServerConnection();
            server = a;

       _ServerConnection.ServerInstance = @".\" + server;   // connects to named instance 

            _ServerConnection.LoginSecure = false;

            _server = new Server(_ServerConnection);

           
            

           
            
           

        }

        public System.Version setServer()
        {
            return _server.Information.Version;
        }
       
    }

 
}
