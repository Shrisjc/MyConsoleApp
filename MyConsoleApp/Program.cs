namespace MyConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            MyClass myClass = new MyClass();
            int j = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i);


            }
            int n = myClass.MySum(j);
            Console.WriteLine(n);
            
            Console.WriteLine();
        }
    }
}
