namespace DsAndAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select Programs \n2.Binary search");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 2:
                        BinarySearch binarysearch = new BinarySearch();
                        binarysearch.Search(@"C:\DsAlgorithm\DsAndAlgorithm\Word.txt");
                        break;
                }
            }
        }
    }
}