using System;
using System.Collections;
using System.Collections.Generic;

namespace MyFirstConsoleAppWithUlf
{
    class Program
    {
        static void Main(string[] args)
        {

            
         

        

        }// End of main method

        static int CheckAge() {
            bool isAnAge;
            int age = 0;

            //What happens while player needs to give their age
            do
            {
                Console.Write("What is your age?");
                isAnAge = int.TryParse(Console.ReadLine(), out age);

                string bounceResponse = !isAnAge ? "Stop fooling around, how old are you?" : $"Okay, since you are {age} years old, you ";
                Console.Write(bounceResponse);

            } while (!isAnAge);

            return age;
        }// End of CheckAge

        static void WhatDrink()
        {
            if (CheckAge() > 17)
            {
                Console.WriteLine("get a nice, cold beer.");
            }
            else
            {
                Console.WriteLine("get a cold, sugery soda.");
            }

        }
        static int PlayerInput()
        {
            bool isNumber = false;
            int input = 0;

            do
            {
                Console.Write("Insert number: ");
                isNumber = int.TryParse(Console.ReadLine(), out input);

               if

            } while (!isNumber);

            return input;
        }


    }
}
