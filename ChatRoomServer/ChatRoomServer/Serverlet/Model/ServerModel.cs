using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;

namespace ChatRoomServer
{
	class ServerModel : MVC.Model
	{
		private Socket Server;
		private IPEndPoint Iep;
		private static List<Socket> ClientList = new List<Socket>();
		private static int Count = 0;

		public override string Name => Consts.M_Server;

		public ServerModel(int port)
		{
			InitializeServer(port);
			SendEvent(Consts.E_Start);
		}

		private void InitializeServer(int port)
		{
			Iep = new IPEndPoint(IPAddress.Parse(this.GetLocalIP()), port);
			Server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			Server.Bind(Iep);
		}

		private void Start()
		{
			while (true)
			{
				Socket ClientSocket = Server.Accept();
				if (ClientSocket != null)
				{
					Count++;
					ClientList.Add(ClientSocket);
				}
			}
		}

		/// <summary>
		/// 这里做的是得到本机的IPv4的IP地址的字符串
		/// </summary>
		/// <returns>IP地址的字符串</returns>
		public string GetLocalIP()
		{
			try
			{
				string HostName = Dns.GetHostName(); //得到主机名
				IPHostEntry IpEntry = Dns.GetHostEntry(HostName);
				for (int i = 0; i < IpEntry.AddressList.Length; i++)
				{
					//从IP地址列表中筛选出IPv4类型的IP地址
					//AddressFamily.InterNetwork表示此IP为IPv4,
					//AddressFamily.InterNetworkV6表示此地址为IPv6类型
					if (IpEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
					{
						return IpEntry.AddressList[i].ToString();
					}
				}
				return null;
			}
			catch (Exception)
			{
				SendEvent(Consts.E_IPError);
				return null;
			}
		}

	}
}
