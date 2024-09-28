using ShareLib;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;

namespace _Server_My_Tcp
{
    class Program
    {
        static TcpListener listener;
        static Dictionary<int, TcpClient> clients = new Dictionary<int, TcpClient>();
        static object _lock = new object();

        static void Main(string[] args)
        {
            listener = new TcpListener(IPAddress.Any, 5000);
            listener.Start();

            Console.WriteLine("Server started...");
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                Thread thread = new Thread(HandleClient);
                thread.Start(client);
            }
        }
        // Method to handle each client in a separate thread
    static void HandleClient(object obj)
    {
        TcpClient client = (TcpClient)obj;
        NetworkStream stream = client.GetStream();
        int clientId = 0;
        bool idAssigned = false;
        BinaryFormatter formatter = new BinaryFormatter();
      
        while (!idAssigned)
        {

               clientId = (int)formatter.Deserialize(stream);
                lock (_lock)
                {
                    if (!clients.ContainsKey(clientId))
                    {
                        clients.Add(clientId, client);
                        idAssigned = true;
                        Console.WriteLine("Client {0} connected.", clientId);
                        formatter.Serialize(stream, "ID_OK");
                         
                    }
                    else
                    {
                        formatter.Serialize(stream, "ID already in use. Please enter a different number.");
                    }
                } 
           
        }

        try
        {
            while (clientId > 0)
            {
                RemotePoint remote = (RemotePoint)formatter.Deserialize(stream);
                
                int targetClientId = (int)formatter.Deserialize(stream);
                Console.WriteLine("Received from Client {0} To {1}", clientId, targetClientId);
                ForwardRemotePoint(targetClientId, remote);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: {0}",ex.Message);
        }
        finally
        {
            lock (_lock)
            {
                clients.Remove(clientId);
            }
            client.Close();
        }
    }

    static void SendMessage(int clientId, string message)
    {
        lock (_lock)
        {
            if (clients.ContainsKey(clientId))
            {
                TcpClient targetClient = clients[clientId];
                NetworkStream stream = targetClient.GetStream();
                byte[] buffer = Encoding.UTF8.GetBytes(message);
                stream.Write(buffer, 0, buffer.Length);
            }
            else
            {
                TcpClient targetClient = clients[clientId];
                NetworkStream stream = targetClient.GetStream();
                byte[] response = Encoding.UTF8.GetBytes("REC_ID_NOT_OK");
                stream.Write(response, 0, response.Length);
                Console.WriteLine("Client {0} not found.",clientId);
            }
        }
    }
    static void ForwardRemotePoint(int clientId,RemotePoint point)
    {
        lock (_lock)
        {
            if (clients.ContainsKey(clientId))
            {
                TcpClient targetClient = clients[clientId];
                NetworkStream stream = targetClient.GetStream();
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, point);
            }
            else
            {
                Console.WriteLine("Client {0} not found.", clientId);
            }
        }
    }
    }
}
