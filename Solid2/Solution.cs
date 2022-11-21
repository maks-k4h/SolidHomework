using System;

namespace Solid2S
{
    // SRP — надсилач повідомлень більше не виконує логування
    // OCP — LoggingEmailSender розширює функціонал EmailSender;
    //       водночас реалізація EmailSender не змінюється
    // LSP — нащадки EmailSender можуть коректно використовуватися там, 
    //       де повинен використовуватися EmailSender
    // ISP --
    // DIP --  


    class Email
    {
        public String Theme { get; set; }
        public String From { get; set; }
        public String To { get; set; }
    }

    class EmailSender
    {
        public virtual void Send(Email email)
        {
            // ... sending...
        }
    }

    abstract class LoggingEmailSender : EmailSender
    {
        protected abstract void Log(string s);
        public override void Send(Email email)
        {
            base.Send(email);
            Log("Email from '" + email.From + "' to '" + email.To + "' was send");
        }
    }

    class ConsoleLoggingEmailSender : LoggingEmailSender
    {
        protected override void Log(string s)
        {
            Console.WriteLine(s);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Email e1 = new Email() { From = "Me", To = "Vasya", Theme = "Who are you?" };
            Email e2 = new Email() { From = "Vasya", To = "Me", Theme = "vacuum cleaners!" };
            Email e3 = new Email() { From = "Kolya", To = "Vasya", Theme = "No! Thanks!" };
            Email e4 = new Email() { From = "Vasya", To = "Me", Theme = "washing machines!" };
            Email e5 = new Email() { From = "Me", To = "Vasya", Theme = "Yes" };
            Email e6 = new Email() { From = "Vasya", To = "Petya", Theme = "+2" };

            EmailSender es = new ConsoleLoggingEmailSender();
            es.Send(e1);
            es.Send(e2);
            es.Send(e3);
            es.Send(e4);
            es.Send(e5);
            es.Send(e6);

            Console.ReadKey();
        }
    }
}