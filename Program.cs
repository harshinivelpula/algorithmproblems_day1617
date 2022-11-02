namespace algorithmproblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("welcome to primenumber problem");
            primenumber.prime();
            
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.Display();

            InsertionSort insertionSort = new InsertionSort();
            InsertionSort.Display();

            Anagram anagram = new Anagram();
            Anagram.Display();

            BinarySearch binarySearch = new BinarySearch();
            Console.WriteLine("Enter string value to search:");
            string userInput = Console.ReadLine();
            Console.WriteLine("User input is " + userInput);
            binarySearch.BinarySearchIterative(userInput);

            FindNumber findNumber = new FindNumber();
            FindNumber.Display();
            char answer = Convert.ToChar(Console.ReadLine());


            MergeSort mergeSort = new MergeSort();
            MergeSort.Display();


        }
    }
}