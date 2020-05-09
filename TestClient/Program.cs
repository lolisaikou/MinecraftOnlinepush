using System;
using MinecraftOutClient.Modules;
using System.Net.Sockets;
using System.IO;
using System.Linq;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {   
                StreamWriter sw = new StreamWriter(@".\Output.txt");
                Console.SetOut(sw);
                Console.Clear();
				//读取python脚本生成的服务器地址
                string ip = File.ReadLines(@".\service.txt").Skip(0).Take(1).First(); // 读取第一行的服务器地址
                string portstring = File.ReadLines(@".\service.txt").Skip(1).Take(1).First(); // 读取第二行的端口
				// 固化到程序内
                // string ip = ""; // 这里设定服务器地址
                // string portstring = ""; //设定服务器端口
                int port;
                port = int.Parse(portstring);
                try
                {
                    ServerInfo info = new ServerInfo(ip, port);
                    info.StartGetServerInfo();
                    foreach (string item in info.OnlinePlayersName)
                    {
                        Console.WriteLine(item);
                    }
                }
                catch (SocketException ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.Write("连接发生异常。");
                    continue;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    Console.Write("发生异常。");
                    continue;
                }
                sw.Flush();
                sw.Close();
                break;
            }
        }
    }
}
