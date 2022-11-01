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
        }
    }
}