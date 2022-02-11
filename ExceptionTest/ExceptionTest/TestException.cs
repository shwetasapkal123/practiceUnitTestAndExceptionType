using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionTest
{
    internal class TestException
    {
        public static void TestArgumentNullException(string name)
        {
            try
            {
                if (name == null)
                {
                    //Console.WriteLine(name.Length);
                    throw new ArgumentNullException("name");
                }
            }
            //catch (ArgumentNullException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            catch (ArgumentException ex)
            {
                //Console.WriteLine(ex.Message);
                throw new NullReferenceException();
            }
        }
            //Argument out of range excption
            public static void TestArgumentOutOfRange(string name)
            {
                //string name = "Shweta";
                try
                {
                    string res = name.Substring((name.Length) + 2);
                    Console.WriteLine(res);
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
        public static void TestIndexOutOfRangeExc(string[] arr)
        {
            try 
            { string arr2=arr[arr.Length + 1];
                Console.WriteLine(arr2);
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
    }
}
