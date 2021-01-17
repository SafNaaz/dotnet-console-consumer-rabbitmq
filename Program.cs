using System;
using RabbitMQ.Client;


namespace ExploreCalifornia.EmailService
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory();
            factory.Uri = new Uri("amqp://guest:guest@localhost:5672");
            var connection = factory.CreateConnection();
            var channel = connection.CreateModel();

            // declare resources here, handle consumed events, etc

            channel.Close();
            connection.Close();

        }
    }
}
