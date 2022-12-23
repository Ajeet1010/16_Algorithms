namespace DSAlgo
{
    class Program
    {
        public static string binaryTextPath = @"E:\Visual Studio\Fellowship\16_Algorithms\DSAlgo\DSAlgo";
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to the Algorithm Programs ");
                Console.WriteLine("1.BinarySearch\n" +
                                  "2.Exit");
                Console.WriteLine(" Select the option ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Search search = new Search();
                        search.ReadTextFile(binaryTextPath);
                        search.BinarySearchOperation("BinarySearch");
                        break;

                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}