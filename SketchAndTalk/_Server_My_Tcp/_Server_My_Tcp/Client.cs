using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _Server_My_Tcp
{
    class Client
    {
        public TcpClient tcpClient { get;  set; }
        public int clientNumber { get;  set; }
    }
}
