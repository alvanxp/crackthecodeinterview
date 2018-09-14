<Query Kind="Statements" />

checkpalindrome("tatatat");
void checkpalindrome(string word)
{
	int[] dic = new int['0'+26];
	int oddCounter = 0;
	for(int i=0;i<word.Length;i++)
	{
		char c =word[i];
		int numValue = (int)c-'0';	
		dic[numValue] = dic[numValue]+1;
		if (dic[numValue] % 2 == 1)
  			oddCounter++;
		else
			oddCounter--;
	}
	if (oddCounter <= 1) Console.WriteLine("es palindrome");
}