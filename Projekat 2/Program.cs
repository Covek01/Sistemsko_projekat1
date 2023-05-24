﻿using System.Net;
using System.Threading;
using System.IO;
using System.Text;

namespace Projekat_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HttpServer server = new HttpServer(".\\Resources\\");
            string[] prefixes = {"http://localhost:8085/"};
            server.StartServer(prefixes);
            Console.Write("Proba");
        }
    }
}