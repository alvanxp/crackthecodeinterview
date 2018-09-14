<Query Kind="Statements" />

checkoperation("ple","pale");//true
checkoperation("pale","ple");//true
checkoperation("pales","pale");//true
checkoperation("pale","bale");//true
checkoperation("pale","bake");//false
void checkoperation(string word1, string word2){
	int countChanges = 0;
	int j=0;
	string wmax = string.Empty, wmin = string.Empty;
	if (word1.Length >= word2.Length) 
	{
		wmax = word1;
		wmin = word2;
	}else
	{
		wmax = word2;
		wmin = word1;
	}
	for (int i = 0; j < wmax.Length && i<wmin.Length;i++)
	{				
		if (wmax[j] != wmin[i])
		{
			countChanges++;
			if (wmax.Length != wmin.Length)
				j++;
		}
		j++;
	}
	if (wmax.Length != wmin.Length && countChanges > 0)
		countChanges =countChanges - Math.Abs( word2.Length - word1.Length);
	Console.WriteLine("change: "+countChanges);
	Console.WriteLine("Add Delete : {0}",word2.Length - word1.Length);
	Console.WriteLine("word1: {0}, word2: {1}", word1, word2);
	if (countChanges >= 2)
	{
		Console.WriteLine("false");
	}else
	Console.WriteLine("true");
}