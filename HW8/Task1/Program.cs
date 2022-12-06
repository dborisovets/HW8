namespace HW8.Task1
{
    public class Program
    {
        static void Main()
        {
            try
            {
                int[] massive = { 8, 7, 1, 4, 2 };
                Console.WriteLine("Input index of element in massive:");
                string? inputedValue = Console.ReadLine();
                string? checkedValue = inputedValue.Equals(string.Empty) ? null : inputedValue;
                int inputtedNumber = Int32.Parse(checkedValue);

                int massiveElement = massive[inputtedNumber];
                Console.WriteLine($"Massive element that has index {inputedValue} has value {massiveElement}");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("ArgumentNullException occured");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("IndexOutOfRangeException occured");
            }
            catch (FormatException)
            {
                Console.WriteLine("FormatException occured");
            }
            finally
            {
                Console.WriteLine("The winter is coming!");
            }

            Console.WriteLine("Program is finished");

        }
    }
}


