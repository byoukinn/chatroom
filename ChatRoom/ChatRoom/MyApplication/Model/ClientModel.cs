using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace ChatRoom
{
    class Client
    {
		private Socket clientSocket;
		private IPEndPoint ep;
		private byte[] bufferReceive = new byte[1024];
        private string message = "";


        public Client(string host, int port)
        {
			clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			ep = new IPEndPoint(IPAddress.Parse(host), port);
			// TODO: 实例化，然后调用连接服务器
			bool isConnect = ConnectToServer();
            if (isConnect)
                ReceiveMessageFormSever();
            else
                return;

        }

        public void SendMassageToServer(Byte[] msg)
        {
            // TODO: 将信息发送出去， 发送一个信息请求
        }

        private bool ConnectToServer()
        {
            try
            {
                clientSocket.Connect(ep);
                Thread rmfs = new Thread(ReceiveMessageFormSever);
                rmfs.Start();
            }catch(Exception){
                return false;
            }
            return true;
        }

        private void ReceiveMessageFormSever() 
        {
            // TODO:  监听来自服务器的消息
            while(true){
                if (clientSocket.Connected)
                {
                    int length = clientSocket.Receive(bufferReceive);
                    message = Encoding.UTF8.GetString(bufferReceive, 0, length);
                } else {
                    break;
                }
            }
        }


    }
}
