using System.Diagnostics;
using System.Net;
using System.Net.Mail;

namespace MultiTaksing
{
    internal class Program
    {
        async static Task Main(string[] args)
        {
            #region Multithreading
            //Thread thread1 = new Thread(MethodA)
            //{
            //    Name = "Thread 1"
            //};

            //Thread thread2 = new Thread(MethodB)
            //{
            //    Name = "Thread 2"
            //};

            //Thread thread3 = new Thread(MethodC)
            //{
            //    Name = "Thread 3"
            //};

            //thread1.Start();
            //thread2.Start();
            //thread3.Start();
            #endregion

            //int result = await Calculate(5, 10);
            //await Write("Salam");
            //Console.WriteLine(result);
            List<string> list = new List<string>()
            {
                "ruslantagizade25@gmail.com",
                "emin.nagiyev.02@gmail.com",
                "raminemrahli1@gmail.com",
                "rehimovrhim399@gmail.com"
            };

            foreach (string s in list)
            {
                SendEmailAsync(s, "<h1>Salam dostlar</h1>", "Test mesaj");
            }
        }

        #region Multithreading
        //static void MethodA()
        //{
        //    for (int i = 0; i < 20; i++)
        //    {
        //        Console.WriteLine(Thread.CurrentThread.Name);
        //        Console.WriteLine("Method A : " + i);
        //    }
        //}

        //static void MethodB()
        //{
        //    for (int i = 0; i < 20; i++)
        //    {
        //        if (i == 10)
        //        {
        //            Thread.Sleep(2000);
        //            Console.WriteLine("Thread is sleeped");
        //        }
        //        Console.WriteLine("Method B : " + i);
        //    }
        //}

        //static void MethodC()
        //{
        //    for (int i = 0; i < 20; i++)
        //    {
        //        Console.WriteLine(Thread.CurrentThread.Name);

        //        Console.WriteLine("Method C : " + i);
        //    }
        //}
        #endregion

        //async static Task<int> Calculate(int a,int b)
        //{
        //    return a + b;
        //}

        //async static Task Write(string text)
        //{
        //    Console.WriteLine(text);
        //}

        // Simple Mail Transfer Protocol

        // sender - Cihaz - receiver
        // xnjhazxheouizkua

        static void SendEmailAsync(string mail,string body,string subject)
        {
            MailMessage message = new MailMessage(from: "sadig.aliev99@gmail.com",
                                to: mail,
                                subject: subject,
                                body: body);
            message.IsBodyHtml = true;
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential("sadig.aliev99@gmail.com", "ngvswvhowspoyxsx")
            };

            client.Send(message);
            Console.WriteLine("Send Message successfully");
        }
    }
    }