<Query Kind="Statements" />

checkpalindrome("tatatatb");
void checkpalindrome(string word)
{
	Dictionary<char, int> dic = new Dictionary<char, int>();
	for(int i=0;i<word.Length;i++)
	{
		char c =word[i];
		if (dic.ContainsKey(c))
	  		dic[c]=dic[c]+1;
	  	else
	  		dic.Add(c, 1);
	}
	int s=0;
	foreach(var c in dic)
	{	
		if (c.Value % 2== 1) s++;
		if(s > 1) return;
	}
	 Console.WriteLine("es palindrome");
}