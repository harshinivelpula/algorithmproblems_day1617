namespace algorithmproblems
{
	public class PrimeAnagram
	{
		public static void main(String[] args)
		{
			PrimeAnagram primeAnagram = new PrimeAnagram();
			for (int i = 0; i <= 1000; i++)
			{
				if (PrimeAnagram.isPrime(i))
				{
					for (int j = i; j < 1000; j++)
					{
						if (i != j)
						{
							if (PrimeAnagram.isPrime(j))
							{
                                if (primeAnagram.isAnagram(primeAnagram.isPrime(i), primeAnagram.isPrime(j)) && primeAnagram.isPalindrome(i))
								{
									Console.WriteLine(i + " " + j + " is prime and anagram and palindrome");
								}
							}
						}
					}

				}

			}
		}

        private static bool isPrime(int i)
        {
            throw new NotImplementedException();
        }

        private bool isPalindrome(int i)
        {
            throw new NotImplementedException();
        }

        private bool isAnagram(object value1, object value2)
        {
            throw new NotImplementedException();
        }
    }
}
