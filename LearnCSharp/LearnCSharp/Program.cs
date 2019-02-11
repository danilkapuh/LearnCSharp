using System;
using System.Collections.Generic;

namespace LearnCSharp
{
    internal class Program
    {
        private const string TextInJune = "Сегодня {0}, у меня в кармане {1}$, это круто!";

        public static void Main(string[] args)
        {
            var months = new List<string> {"Январь", "Февраль", "Март", "Апрель", "Май","Июнь","Июль","Август", "Сентябрь","Октябрь","Ноябрь","Декабрь"};
            var money = GetInitialMoney();
            foreach (var month in months)
            {
                var addMoney = CalcAddMoney(month, money);
                money += addMoney;
                InfoMoney(money, month);                                              
                InfoMoney(money, month);       
                
            }

        }

        private static int GetInitialMoney()
        {
            var seconds = DateTime.Now.Second;
            if (seconds >= 30)
            {
                return -100;
            }
            else
            {
                return seconds;
            }

        }

        public static int CalcAddMoney(string month, int money)
        {
            if (money<20 || month=="Июль")
            {
                return month.Length;
            }
            else
            {
                return 1000;
            }
        }
        public static void InfoMoney(int money, string month)
        {
            if (money > 100 && month.Equals("Июнь"))
            {
                Console.WriteLine(TextInJune,month,money);
            }                                                                
            else
            {
                Console.WriteLine(month+": "+money);
            }
        }
    }
}