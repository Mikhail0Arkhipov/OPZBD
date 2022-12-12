using System;
using System.Configuration;
using SportClub;
using DataAccessLayer;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            var training = new Training("2345");
            var coaches = new Coach("Petrov", "Petr", null);
            var clients = new Clients("Ivanov", "Ivan", "Ivanovich", coaches);
            clients.AddTraining(training);
            Console.WriteLine(clients);
            Console.ReadKey(true);
            var settings = new Settings();
            settings.AddDatabaseServer("AX3RIP4IK\\SQLEXPRESS");
            settings.AddDatabase("SportClub");
            using var sessionFactory = Configurator.GetSessionFactory(settings, showSql: true);
            using (var session = sessionFactory.OpenSession())
            {
                session.Save(training);
                session.Save(coaches);
                session.Save(clients);
                session.Flush();
            }
        }
    }
}
