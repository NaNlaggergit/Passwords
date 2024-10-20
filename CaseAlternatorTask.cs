namespace Passwords;

public class CaseAlternatorTask
{
	//Тесты будут вызывать этот метод
	public static List<string> AlternateCharCases(string lowercaseWord)
	{
		//var result = new List<string>();
		HashSet<string> result = new HashSet<string>();
		AlternateCharCases(lowercaseWord.ToCharArray(), 0, result);
		return result.ToList();
	}

	static void AlternateCharCases(char[] word, int startIndex, HashSet<string> result)
	{
		if (startIndex < word.Length)
		{
            if (char.IsLetter(word[startIndex]))
            {
				word[startIndex] = char.ToLower(word[startIndex]);
				AlternateCharCases(word, startIndex + 1, result);
				word[startIndex] = char.ToUpper(word[startIndex]);
				AlternateCharCases(word, startIndex + 1, result);
            }
			else
			{
				AlternateCharCases(word, startIndex+1, result);
			}
        }
		else 
			result.Add(new string (word));
	}
}