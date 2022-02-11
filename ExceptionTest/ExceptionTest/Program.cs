using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTest
{
    public class Program
    {
        public int Addition(int first, int second)
        {
            return first + second;
        }
        public int Subtraction(int first,int second)
        {
            return first-second;
        }
        public int Divide(int first,int second)
        { 
            return first/second; 
        }
        public int Multiply(int first,int second)
        { 
            return first*second;
        }
        static void Main(string[] args)
        {
            //Exception handle type exampples
            //1.null reference exception
            //try
            //{
            //    string name = null;
            //    Console.WriteLine(name.Length);
            //}
            ////Null Reference Exception
            //catch (NullReferenceException ex)
            //{ 
            //    Console.WriteLine(ex.Message); 
            //}
            ////Parent Exception Handler
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //2.exception base class or parent class
            //try
            //{
            //   string name = null;
            //    Console.WriteLine(name.Length);
            //}
            //catch (Exception exception)
            //{
            //    Console.WriteLine(exception.Message);            
            //}

            //TestException.TestArgumentNullException(name);
            string[] name = {"test"};
            //TestException.TestArgumentOutOfRange(name);
            TestException.TestIndexOutOfRangeExc(name);
            Console.ReadLine();
        }
        
    }
}
