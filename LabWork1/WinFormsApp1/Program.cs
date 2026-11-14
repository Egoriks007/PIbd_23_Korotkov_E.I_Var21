using LabWork1.Forms;
using LabWork1.Repositories;
using LabWork1.Repositories.Implementations;
using Unity;
using Unity.Lifetime;

namespace LabWork1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Вместо new MainForm() используем IoC-контейнер
            var container = CreateContainer();
            Application.Run(container.Resolve<MainForm>());
        }

        // Метод для настройки IoC-контейнера
        private static IUnityContainer CreateContainer()
        {
            var container = new UnityContainer();

            // Регистрируем все интерфейсы и их реализации (заглушки)
            container.RegisterType<IClientRepository, ClientRepository>(new TransientLifetimeManager());
            container.RegisterType<IApartmentRepository, ApartmentRepository>(new TransientLifetimeManager());
            container.RegisterType<IServiceRepository, ServiceRepository>(new TransientLifetimeManager());
            container.RegisterType<IDealRepository, DealRepository>(new TransientLifetimeManager());
            container.RegisterType<IProvidedServiceRepository, ProvidedServiceRepository>(new TransientLifetimeManager());

            return container;
        }
    }
}