using AppCoreTareaBlocNotas.IServices;
using AppCoreTareaBlocNotas.Services;
using Autofac;
using DomainTareaBlocNotas.Interfaces;
using InfraestructureTareaBlocNotas.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormularioTareaBlocNotas
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

            var builder = new ContainerBuilder();

            builder.RegisterType<ListBlocNotasRepository>().As<IBlocNotasModel>();
            builder.RegisterType<BlocNotasService>().As<IBlocNotasService>();

            var container = builder.Build();

            Application.Run(new Form1(container.Resolve<IBlocNotasService>()));
        }
    }
}
