<Query Kind="Statements" />

string input = "w yo soy alva      ";
replace(input.ToArray(), input.Trim().Length);
void replace(char[] word, int wlenght)
{
	int initial = input.Length - wlenght;
	int reverseStart = input.Length-initial - 1;
	int a = input.Length-1;
	for(int index = reverseStart; index>=0;index--)
	{
		if (word[index]==' ')
		{
			word[a--]='0';
			word[a--]='2';
			word[a--]='%';
			continue;
		}
		word[a] = word[index];		
		a--;
	}
	
	Console.WriteLine(new String(word));
}