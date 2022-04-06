using LiberadorSUAT.ModelsSecundarios;
using LiberadorSUAT.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiberadorSUAT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SideBarLayout());

           var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.Configure<ConfiguracoesBancoLiberador>(
                builder.Configuration.GetSection("ConfiguracoesBancoLiberador"));
        }
    }
}
