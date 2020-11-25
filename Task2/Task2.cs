using System;
using System.Collections.Generic;

namespace Task2
{
    class Email
    {
        public String Theme { get; set; }
        public String From { get; set; }
        public String To { get; set; }
    }

    /*Порушений принцип відкритості/закритості. Якщо ми захочемо змінити форму логування,
    то ми будемо змушені внести правки в клас EmailSender.*/
    
    interface IEmailSendingFormatter
    {
        void FormatReport(Email email);
    }

    class FormFormatter : IEmailSendingFormatter
    {
        public void FormatReport(Email email)
        {
            Console.WriteLine("Email from '" + email.From + "' to '" +
               email.To + "' was send");
        }
    }

    class EmailSender
    {
        public void Send(Email e, IEmailSendingFormatter formatter)
        {
            // ... sending...
            formatter.FormatReport(e);

            /*Console.WriteLine("Email from '" + email.From + "' to '" +
            email.To + "' was send");*/
        }
    }

    class Task2
    {
        static void Main(string[] args)
        {
            IEmailSendingFormatter formatter = new FormFormatter();

            Email e1 = new Email()
            {
                From = "Me",
                To = "Vasya",
                Theme = "Who are you ? " };
            Email e2 = new Email()
            {
                From = "Vasya",
                To = "Me",
                Theme = "vacuum cleaners!"
            };
            Email e3 = new Email()
            {
                From = "Kolya",
                To = "Vasya",
                Theme = "No! Thanks!"
            };
            Email e4 = new Email()
            {
                From = "Vasya",
                To = "Me",
                Theme = "washing machines!"
            };
            Email e5 = new Email()
            {
                From = "Me",
                To = "Vasya",
                Theme = "Yes"
            };
            Email e6 = new Email()
            {
                From = "Vasya",
                To = "Petya",
                Theme = "+2"
            };
            EmailSender es = new EmailSender();
            es.Send(e1, formatter);
            es.Send(e2, formatter);
            es.Send(e3, formatter);
            es.Send(e4, formatter);
            es.Send(e5, formatter);
            es.Send(e6, formatter);
            Console.ReadKey();
        }
    }
}
