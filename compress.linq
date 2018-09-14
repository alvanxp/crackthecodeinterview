<Query Kind="Statements" />

var result = compress("aabcccccaaa");
Console.WriteLine(result);
//"a2b1c5a3"
string compress(string str)
{
	StringBuilder sb = new StringBuilder();
	int i =0, j=1 ;	
	do
	{
		char c =str[i]; 
		if (j==str.Length || c != str[j] )
	  	{
      		sb.Append(j-i);
			sb.Append(c);
		  	i = j;
			
		}
		j++;
	}while (j <= str.Length);
	return sb.ToString();
}