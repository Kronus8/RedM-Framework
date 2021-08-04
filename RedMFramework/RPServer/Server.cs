using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CitizenFX.Core;
using RPServer.Database;

namespace RPServer
{
    public class Server : BaseScript
    {
        public Server()
        {
            MySQL.Connect("localhost",3306,"default","root","");

            if (MySQL.IsOpen)
            {
                Debug.WriteLine("Database Connection Established");
            }
        }
    }
}
