using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using DSharpPlus;


namespace CheezeBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Run().GetAwaiter().GetResult();
        }

        public static async Task Run()
        {
            var discord = new DiscordClient(new DSharpPlus.DiscordConfig
            {
                AutoReconnect = true,
                DiscordBranch = Branch.Stable,
                LargeThreshold = 250,
                LogLevel = LogLevel.Unnecessary,
                Token = "MzEyOTgwODQ4NzkyMzA1NjY0.C_jAHw.RH5d6uRDiNQQUGjjJ1SAOo2iQ2M",
                TokenType = DSharpPlus.TokenType.Bot,
                UseInternalLogHandler = false
            });

            discord.DebugLogger.LogMessageReceived += (o, e) =>
            {
                Console.WriteLine($"[{e.Timestamp}] [{e.Application}] [{e.Level}] {e.Message}");
            };

            discord.GuildAvailable += e =>
            {
                discord.DebugLogger.LogMessage(LogLevel.Info, "discord bot", $"Guild available: {e.Guild.Name}", DateTime.Now);
                return Task.Delay(0);
            };

            discord.MessageCreated += async e =>
            {
                if (e.Message.Content.ToLower() == "c:ping")
                    await e.Message.RespondAsync("pong");
                if (e.Message.Content.ToLower() == "c:help")
                    await e.Message.RespondAsync("The following commands are available: 'c:help','c:ping' For more commands related to Cheeze's Content pack use: 'c:cheezemod.help'");
                if (e.Message.Content.ToLower() == "c:cheezemod.help")
                    await e.Message.RespondAsync("The following commands are available: 'c:cheezemod.download, 'c:cheezemod.help', 'c:cheezemod.stats', 'c:cheezemod.wiki'");
                if (e.Message.Content.ToLower() == "c:cheezemod.wiki")
                    await e.Message.RespondAsync("The wiki for the mod can be found at http://cheezes-content-pack.wikia.com/wiki/Cheeze%27s_Content_Pack_Wiki");
                if (e.Message.Content.ToLower() == "c:cheezemod.download")
                    await e.Message.RespondAsync("The latest version of the mod can be downloaded at http://javid.ddns.net/tModLoader/mods/CheezeMod.tmod");
                if (e.Message.Content.ToLower() == "c:cheezemod.stats")
                {
                    WebClient client = new WebClient();
                    string downloadString = client.DownloadString("http://javid.ddns.net/tModLoader/tools/modinfo.php?modname=CheezeMod");
                    await e.Message.RespondAsync(downloadString);
                }
            };

            await discord.ConnectAsync();

            await Task.Delay(-1);

        }
    }
}
