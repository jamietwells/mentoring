using System;
using System.Collections.Generic;

namespace Mentoring
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter your number:");
            string input = Console.ReadLine();
            Console.WriteLine("Your number : " + input);
            int inputconv = Convert.ToInt32(input);
           var factorcalc = new FactorsCalculator(inputconv);
           
           foreach(var factor in factorcalc.GetFactors())
           {
               Console.WriteLine(factor);
               
           } 

           //Console.WriteLine(factorcalc.GetFactors());



        }



    }

    class FactorsCalculator
    {
        int _input;

        public FactorsCalculator(int input)
        {
            this._input = input;
        }

        public List<int> GetFactors()
        {
            var FactorsList = new List<int>();

            for (int i = 1; i <= _input; i = i + 1)
            {

                if (_input % i == 0)
                {
                    FactorsList.Add(i);
                }
            }

            return FactorsList;

        }


    }





    /*
        Task 1: Create a program to find all the factors of any positive integer.

        For example:

            Input: 12
            Output: 1, 2, 3, 4, 6, 12

            Input: 7
            Output: 1, 7

            Input: 16
            Output: 1, 2, 4, 8, 16

     */
}
