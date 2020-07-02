using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using System.Threading;
using Discord.WebSocket;
using System.Net;
using System.IO;
using System.Security.Policy;

namespace Mabel_Rainbow
{
    class Program
    {
        private static DiscordSocketClient _client;
        private static string _token;
        private static readonly object guildresult;

        static void Main(string[] args)
        {
            string token = "";
            Console.Title = "Mabel Coloring";


            Console.WriteLine("");



            Console.ForegroundColor = ConsoleColor.Cyan;
            Colorful.Console.WriteAscii("Mabel Rainbow Role");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("________________________________________________________________________________________________________________________");

            Console.ForegroundColor = ConsoleColor.Red;

            if ((Properties.Settings.Default.Token == "null") || (Properties.Settings.Default.Token == ""))
            {
                Console.Write("Bot Token: ");
                Console.ForegroundColor = ConsoleColor.Green;
                token = Console.ReadLine();
                Properties.Settings.Default.Token = _token;
                Properties.Settings.Default.Save();

            }
            else
            {
                token = Properties.Settings.Default.Token;
            }
            _token = token;

            Console.Clear();

            _client = new DiscordSocketClient();


            _client.LoginAsync(TokenType.Bot, token);
            _client.Ready += ReadyAsync;
            _client.Log += _client_Log;
            _client.StartAsync();



            Thread.Sleep(-1);
        }

        private static Task _client_Log(LogMessage arg)
        {
            Log(arg.Message, ConsoleColor.Red);
            return Task.CompletedTask;
        }
        private static void Log(string message, ConsoleColor consoleColor)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Wait...");

        }
        private async static Task<Task> ReadyAsync()
        {
            Console.Clear();





            Console.Title = $" Mabel Rainbow Role | {_client.CurrentUser.Username}#{_client.CurrentUser.Discriminator}";

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Login succes : " + _client.CurrentUser.Username + "#" + _client.CurrentUser.Discriminator);

            System.Threading.Thread.Sleep(4700);

            Console.Clear();
            Console.WriteLine("Login succes : " + _client.CurrentUser.Username + "#" + _client.CurrentUser.Discriminator);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Colorful.Console.WriteAscii("Mabel Rainbow Role");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hi " + _client.CurrentUser.Username + " press 1 ");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("___________________________________________________________________________________________________________________");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[1] Beautiful Rainbow Role        ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("____________________________________________________________________________________________________________________");
            Console.ForegroundColor = ConsoleColor.Green;





            string mas = Console.ReadLine();



            if (mas == "1")

            {

                Console.Write("Guild ID : ");
                string guildid2 = Console.ReadLine();


                ulong id = Convert.ToUInt64(guildid2);

                Console.Write("Role ID : ");
                string roleID = Console.ReadLine();

                ulong roleid = Convert.ToUInt64(roleID);



                SocketGuild guild = _client.GetGuild(id);

                for (int i = 1; i <= 40; i++) // edit "40" for the number of the rainbow role repeat
                {
                    foreach (SocketRole role in guild.Roles)
                    {

                        if (role.Id == roleid)
                        { 


                        try
                        {
                            //wait 30 second and can start :) 

                            await role.ModifyAsync(x => x.Color = new Color(240, 62, 62));
                            System.Threading.Thread.Sleep(1500);
                            await role.ModifyAsync(x => x.Color = new Color(238, 134, 64));
                            System.Threading.Thread.Sleep(1500);
                            await role.ModifyAsync(x => x.Color = new Color(255, 0, 253));
                            System.Threading.Thread.Sleep(1500);
                            await role.ModifyAsync(x => x.Color = new Color(2, 253, 254));
                            System.Threading.Thread.Sleep(1500);
                            await role.ModifyAsync(x => x.Color = new Color(254, 232, 21));
                            System.Threading.Thread.Sleep(1500);
                            await role.ModifyAsync(x => x.Color = new Color(83, 232, 21));
                            System.Threading.Thread.Sleep(1500);
                            await role.ModifyAsync(x => x.Color = new Color(0, 3, 39));
                            System.Threading.Thread.Sleep(1500);

                            await role.ModifyAsync(x => x.Color = new Color(115, 3, 39));
                            System.Threading.Thread.Sleep(1500);
                            await role.ModifyAsync(x => x.Color = new Color(115, 149, 39));
                            System.Threading.Thread.Sleep(1500);
                            await role.ModifyAsync(x => x.Color = new Color(250, 108, 3));
                            System.Threading.Thread.Sleep(1500);
                            await role.ModifyAsync(x => x.Color = new Color(250, 108, 221));
                            System.Threading.Thread.Sleep(1500);
                            await role.ModifyAsync(x => x.Color = new Color(80, 44, 58));
                            System.Threading.Thread.Sleep(1500);
                            await role.ModifyAsync(x => x.Color = new Color(0, 80, 0));
                            System.Threading.Thread.Sleep(1500);
                            await role.ModifyAsync(x => x.Color = new Color(0, 80, 249));
                            System.Threading.Thread.Sleep(1500);




                        }
                        catch (Exception)
                        {


                        }

                        }



                    }
                }





                await Program.ReadyAsync();







            }


            return Task.CompletedTask;



        }
    }
}
