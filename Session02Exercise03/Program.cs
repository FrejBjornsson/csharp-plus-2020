using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;

namespace Session02Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mata in värden, separerat med kommatecken");
            var input = Console.ReadLine();
            var inputArray = input.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
            double[] numberArray = new double[inputArray.Length];

            for (int i = 0; i < inputArray.Length; i++)

            try
                 {
                numberArray[i] = Convert.ToDouble(inputArray[i]);
                 }
                
            catch (Exception)
           
                {
                numberArray[i] = 0;
                }
            
            finally
                { 
               
                }


            foreach (var number in numberArray)
            {
                Console.WriteLine("Värde:" + number.ToString());
                
            }
               
            }
        }
    }
