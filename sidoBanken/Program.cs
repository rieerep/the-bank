﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace sidoBanken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] userNames = new string[] { "Fred", "Kjell", "Bo", "Tor", "Hel", "Bal" };
            string[] passwords = new string[] { "123", "123456", "321" };
            int[] account1 = new int[] { 10000, 20000, 30000 };
            int[] account2 = new int[] { 23232, 232323, 23223 };
            //string currentUser = Console.ReadLine();
            //string currentPassword = Console.ReadLine();
            Console.WriteLine("Välkommen till banken!");
            MainLogin(userNames, passwords);
            //LoggedIn(); // todo: flytta in till inuti if-satsen

        }

        static void MainLogin(string[] userNames, string[] passwords)
        {
            bool mainMenu = true;
            int loginAttempts = 2;

            while (mainMenu)
            {
                //string[] userNames = new string[] { "Fred", "Kjell", "Bo", "Tor", "Hel", "Bal" };
                //string[] passwords = new string[] { "123", "123456", "321" };

                //bool contains = false;
                Console.Write("Skriv in ditt användarnamn: ");
                string user = Console.ReadLine(); // current user = användarnamnet som är i string-variabeln 'user' 
                Console.Write("Skriv in ditt lösenord: ");
                string pass = Console.ReadLine(); // current pass = lösenordet som är i string-variabeln 'pass' 
                for (int i = 0; i < passwords.Length; i++)
                {
                    //Console.WriteLine(userNames[i]);
                    //Console.WriteLine(passwords[i]);

                    if (user == userNames[i] && pass == passwords[i])
                    {
                        //contains = true;
                        //Console.Clear();
                        Console.WriteLine("Du loggades in!");
                        // anropa logged in
                        // nollställ loginattempts = 2
                        LoggedIn(i);
                        //flytta ut mainMenu = false utanför loopen
                        mainMenu = false;
                        break;
                    }
                    else
                    {
                        loginAttempts--; // todo: flytta utanför for-loopen, så att alla konton kollas för en lyckas inloggning INNAN attempts minskar
                        Console.WriteLine("Invalid input");
                        Console.Write("Skriv in ditt användarnamn: ");
                        user = Console.ReadLine(); // current user = användarnamnet som är i string-variabeln 'user' 
                        Console.Write("Skriv in ditt lösenord: ");
                        pass = Console.ReadLine(); // current pass = lösenordet som är i string-variabeln 'pass'
                        
                    }

                }
                // TODO: Här kan du veta om användaren ej lyckaades logga in
                // minska loginattempts
                // ge en ny chans om an har attempts kvar
                
                if (loginAttempts == 0)
                {
                    Console.WriteLine("Programmet stängs ner!");
                    Console.ReadLine();
                    // todo: stängs programmet verkligen ner? Vad avgör?
                }              
                
            }
        }

        static void LoggedIn(int currentUser)

        {
            int[] account1 = new int[] { 10000, 20000, 30000 };
            int[] account2 = new int[] { 23232, 232323, 23223 };
            //Console.WriteLine("Du är inloggad!");
            //Console.WriteLine("Tryck på enter för att få menyval.");
            Console.WriteLine("1. Se dina konton och saldo\n2. Överföring mellan konton\n3. Ta ut pengar\n4. Logga ut");
            string userChoice = Console.ReadLine();
            int nrChoice = int.Parse(userChoice); 

            switch (userChoice)
            {
                case "1":
                    
                    Console.WriteLine("1. Se dina konton och saldo");

                    break;
                case "2":
                    
                    Console.WriteLine("2. Överföring mellan konton");
                    TransferMoney(account1, account2, currentUser);
                    break;
                case "3":
                    
                    Console.WriteLine("3. Ta ut pengar");
                    break;
                default:
                    Console.WriteLine("4. Logga ut");
                    break;
            }
        }

        static void TransferMoney(int[] account1, int[] account2, int currentUser)
        {
            Console.WriteLine("Account1 " + account1[currentUser]);
            Console.ReadKey();
        }

    } 
}
