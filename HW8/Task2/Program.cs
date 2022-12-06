using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HW8.Task2
{
    public class Program
    {
        private static void Main(string[] args)
        { 
            try
            {
                Client client = new Client() { Experience = 1, Name = "Masha" };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine();
            }
            try
            {
                Client newClient = new Client() { Experience = 3, Name = "Pasha", Nation = "Russian" };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine();
            }
            try
            {
                Client oldClient = new Client() { Experience = 50, Name = "Dima", Nation = "Belarus", Age = 75 };
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine();
            }
        }
    }
}
