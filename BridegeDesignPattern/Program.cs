using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridegeDesignPattern
{
    public interface IMessageSender
    {
        void SendMessage(string subject, string body);
    }

    public abstract class Message
    {
        public string Body { get; set; }
        public IMessageSender MessageSender { get; set; }
        public string Subject { get; set; }

        public abstract void Send();
    }

    public class SystemMessage : Message
    {
        public override void Send()
        {
            MessageSender.SendMessage(Subject, Body);
        }
    }

    public class TextSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            string messageType = "Text";
            Console.WriteLine($"{messageType}");
            Console.WriteLine("----------------");
            Console.WriteLine($"Subject{subject} from {messageType}]\nBody {body}");
        }
    }

    public class WebserviceSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            string messageType = "Web Service";
            Console.WriteLine($"{messageType}");
            Console.WriteLine("----------------");
            Console.WriteLine($"Subject{subject} from {messageType}]\nBody {body}");
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            IMessageSender text = new TextSender();
            IMessageSender web = new WebserviceSender();

            Message message = new SystemMessage();
            message.Subject = "A message";
            message.Body = "Hi there, please accept this message";

            message.MessageSender = text;
            message.Send();

            message.MessageSender = web;
            message.Send();

            Console.ReadKey();
        }
    }
}