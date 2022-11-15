
string[] arr1 = {"Hello", "2", "world", ":-)"};
string[] arr2 = {"1234", "1567", "-2", "computer science"};
string[] arr3 = {"Russia", "Denmark", "Kazan",};

int MAX_WORD_LENGTH = 3;
		
string[] GetShortWordsArray(string[] array)
	{
	int length = array.Length;			
	string[] result = new string[length];
	int count = 0;
			
		for (int i = 0; i < length; i++)
		{
		    if(array[i].Length <= MAX_WORD_LENGTH)
			{
				result[count] = array[i];
				count++;
			}
		}
			Array.Resize(ref result, count);
			
			return result;
	}
		
void PrintArray(string[] array)
	{
		if(array.Length == 0)
		{
		    Console.WriteLine("таких значений нет");
		}
		else
		{
			Array.ForEach(array, (str) => Console.Write($"{str} "));
			Console.WriteLine();
		}
		}