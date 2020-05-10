using MinecraftOutClient.Modules;
using System;
using System.IO;
using System.Linq;
using System.Net.Sockets;

namespace TestClient
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                FileStream fs = new FileStream("Output.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
                StreamWriter writer = new StreamWriter(fs);
                //Console.SetOut(writer);
                //Console.Clear();
                //读取python脚本生成的服务器地址
                string ip = File.ReadLines("service.txt").First(); // 读取第一行的服务器地址
                string portstring = File.ReadLines("service.txt").Last(); // 读取第二行的端口
                //Console.WriteLine(ip);
                //Console.Write(portstring);
                // 固化到程序内
                //string ip = ""; // 这里设定服务器地址
                //string portstring = ""; //设定服务器端口
                int port;
                port = int.Parse(portstring);
                try
                {
                    ServerInfo info = new ServerInfo(ip, port);
                    info.StartGetServerInfo();
                    if (info.OnlinePlayersName != null && info.OnlinePlayersName.Any())
                    {
                        foreach (var item in info.OnlinePlayersName)
                        {
                            writer.WriteLine(item);
                        }
                    }
                }
                catch (SocketException ex)
                {
                    writer.WriteLine(ex.Message, "连接发生异常。");
                    break;
                }
                catch
                {
                    writer.WriteLine("发生异常。");
                    break;
                }
                writer.Flush();
                writer.Close();
                break;
            }
        }
    }
}
