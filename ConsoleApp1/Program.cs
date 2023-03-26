using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

        public static bool isRotatedPalindrome(String s)
        {
            //"BAABCC"
            // CBAABC

            //for(int i = 0; i < s.Length; i++)
            //{

            //}
            int i = 0;
            int div = 0;

            char actual = s[i];
            int cont = 0;
            while (i  < s.Length)
            {
                if(actual == s[i])
                {
                    cont++;
                }
                else
                {
                    if(cont > 1)
                    {
                        div = i;
                        break;
                    }

                    cont = 0;
                }
                i++;
            }



        }
        static void Main(string[] args)
        {



            Console.ReadLine();

        }
    }
}
