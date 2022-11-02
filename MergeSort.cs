namespace algorithmproblems
{
    public class MergeSort
	{
		public static void Display()
		{
			MergeSort mergeSort = new MergeSort();
			String[] arr = { "charu", "chocky", "haswika", "haswik", "kavitha", "ravi" };
			int start = 0, end = arr.Length - 1;
			mergeSort.mergeSort(arr, start, end);
            MergeSort.printStringArr(arr);

		}

        private void mergeSort(string[] arr, int start, int end)
        {
            throw new NotImplementedException();
        }

        private static void printStringArr(string[] arr)
        {
            throw new NotImplementedException();
        }

        
    }
}
