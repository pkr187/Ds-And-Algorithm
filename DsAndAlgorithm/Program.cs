namespace DsAndAlgorithm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select Programs \n2.Binary search \n3.Insertion sort \n4.Bubble sort  \n5.Merge Sort \n6.Check string is Anagram \n7.Print prime number \n");
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
                    case 4:
                        BubbleSort bubblesort = new BubbleSort();
                        bubblesort.Sort(@"C:\DsAlgorithm\DsAndAlgorithm\Word.txt");
                        break;
                    case 5:
                        MergeSort mergeSort = new MergeSort();
                        int n = 8;
                        int[] array = { 49, 3, 53, 21, 27, 75, 50, 41 };
                        Console.WriteLine("Merge Sort");
                        Console.Write("Initial array is: ");
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write(array[i] + " ");
                        }
                        mergeSort.Sort(array, 0, n - 1);
                        Console.Write("\nSorted Array is: ");
                        for (int i = 0; i < n; i++)
                        {
                            Console.Write(array[i] + " ");
                        }
                        Console.WriteLine();
                        break;
                    case 6:
                        Anagram anagram = new Anagram();
                        anagram.AnagramWord("heart", "earth");
                        break;
                    case 7:
                        PrimeNumber primeNumber = new PrimeNumber();
                        primeNumber.Prime();
                        break;
                }
            }
        }
    }
}