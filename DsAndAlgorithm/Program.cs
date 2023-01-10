namespace DsAndAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select Programs \n2.Binary search \n3.Insertion sort\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 2:
                        BinarySearch binarysearch = new BinarySearch();
                        binarysearch.Search(@"C:\DsAlgorithm\DsAndAlgorithm\Word.txt");
                        break;
                    case 3:
                        InsertionSort insertionsort = new InsertionSort();
                        insertionsort.Insertion();
                        break;
                }
            }
        }
    }
}
            