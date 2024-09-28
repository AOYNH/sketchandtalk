using ShareLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MagnetDrawBoard
{
    public class Client
    {
        private TcpClient client;
        private NetworkStream stream;
        // Define an event to notify about received messages
        public event Action<string> MessageReceived;
        public event Action<RemotePoint> DataReceived;
        public string Id { get; set; }


        

        // Method to connect to the server
        public bool ConnectToServer(string serverAddress, int port)
        {
            try
            {
                client = new TcpClient();
                client.Connect(serverAddress, port);
                stream = client.GetStream();
                Console.WriteLine("Connected to server at " + serverAddress + ":" + port);
                return true; // Successfully connected
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to connect to server: " + ex.Message);
                return false; // Connection failed
            }
        }

        // Method to check client ID
        public bool CheckingTheID(int clientId )
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, clientId);
                string response = (string)formatter.Deserialize(stream);

                if (response == "ID_OK")
                {
                    //Console.WriteLine("Client ID is valid.");
                    Id = clientId.ToString();
                    return true; // Client ID is valid
                }
                else
                {
                   // Console.WriteLine("Invalid client ID: " + response);
                    return false; // Client ID is invalid
                }
            }
            catch (Exception ex)
            {
               // Console.WriteLine("Error checking client ID: " + ex.Message);
                return false; // Error in client ID check
            }
        }
        // Method to send messages to the server
        public void SendingMessage(string message)
        {
            try
            {
                    byte[] buffer = Encoding.UTF8.GetBytes(message);
                    stream.Write(buffer, 0, buffer.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending message: " + ex.Message);
            }
        }
        public void SendingData(RemotePoint remotepoint, int targetClientId)
        {
            try
            {
                NetworkStream stream = client.GetStream();
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, remotepoint);
                formatter.Serialize(stream, targetClientId);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error sending data: " + ex.Message);
            }
        }

        // Method to receive messages from the server
        public void ReceivingMessage()
        {
            try
            {
                byte[] buffer = new byte[1024];
                int byteCount;

                while ((byteCount = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    string message = Encoding.UTF8.GetString(buffer, 0, byteCount);
                    if (MessageReceived != null)
                    {
                        MessageReceived(message);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error receiving message: " + ex.Message);
            }
            
        }
        public void ReceiveData()
        {
            try
            {
                NetworkStream stream = client.GetStream();
                BinaryFormatter formatter = new BinaryFormatter();


                while (true)
                {
                    RemotePoint remote = (RemotePoint)formatter.Deserialize(stream);
                    Console.WriteLine("Received: {0}", remote);
                    if (DataReceived != null)
                    {
                        DataReceived(remote);
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error receiving message: " + ex.Message);
            }
         
        }

        // Method to start receiving messages in a separate thread
        public void StartReceivingMessages()
        {
            Thread receiveThread = new Thread(ReceiveData);
            receiveThread.Start();
        }
    }
}
