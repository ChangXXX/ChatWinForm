﻿using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Windows.Forms;
using ChatWinForm.Chat;
using ChatWinForm.Walkthrough;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ChatWinForm
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var host = CreateHostBuilder().Build().Services;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(host.GetService<WalkThrough>());
        }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    services.AddHttpClient(
                        "Base", options =>
                        {
                            options.BaseAddress = new Uri(ServerUrl.Server);
                            options.DefaultRequestHeaders.Accept.Add(
                                new MediaTypeWithQualityHeaderValue("application/json")
                            );
                        }
                    );
                    services.AddSingleton<IFormFactory, FormFactory>();
                    services.AddSingleton<ISignService, SignService>();
                    services.AddSingleton<IUserService, UserService>();

                    var forms = typeof(Program).Assembly
                    .GetTypes()
                    .Where(x => x.BaseType == typeof(Form))
                    .ToList();
                    foreach (var form in forms)
                    {
                        services.AddTransient(form);
                    }
                });
        }
    }

    public static class ServerUrl
    {
        private static string Base = "https://localhost:7239/";
        public static string Server = Base+"api/";
        public static string Hub = Base+"chatHub/";
    }
}
