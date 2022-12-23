namespace DSAlgo
{
    class Program
    {
        public static string binaryTextPath = @"E:\Visual Studio\Fellowship\16_Algorithms\DSAlgo\DSAlgo\12.txt";
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to the Algorithm Programs ");
                Console.WriteLine("1.BinarySearch\n" +
                                  "2.Insertion Sort\n3.Bubble Sort\n4.Anagram\n" +
                                  "5.String function & Regex\n6.Exit");
                Console.WriteLine("Select the option ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Search search = new Search();
                        search.ReadTextFile(binaryTextPath);
                        search.BinarySearchOperation("BinarySearch");
                        break;

                    case 2:
                        int[] arr = { 2, 1, 3 };
                        Insertion insertion = new Insertion();
                        insertion.Sort(arr);
                        break;

                    case 3:
                        Bubble bubble = new Bubble();
                        int[] arr2 = { 5, 2, 1, 4, 3 };
                        bubble.Sort(arr2);
                        break;

                    case 4:
                        Anagram anagram = new Anagram();
                        anagram.CheckAnagram("abcd", "dcba");
                        break;

                    case 5:
                        RegEx regEx = new RegEx();
                        regEx.ReplaceString();
                        break;

                    case 6:
                        flag = false;
                        break;
                }
            }
        }
    }
}