<Query Kind="Program" />

void Main()
{
//	int[][] m = new int[4][];
//	m[0] = new int[] { 1, 2, 3, 4 };
//	m[1] = new int[] { 5, 6, 7, 8 };
//	m[2] = new int[] { 9, 10, 11, 12 };
//	m[3] = new int[] { 13, 14, 15, 16 };


	int[][] m = new int[6][];
	m[0] = new int[] { 1, 2, 3, 4 , 6,5};
	m[1] = new int[] { 5, 6, 7, 8 ,5,6};
	m[2] = new int[] { 9, 10, 11, 12 ,9,3};
	m[3] = new int[] { 13, 14, 15, 16,7,4 };
	m[4] = new int[] { 17, 18, 19, 20,6,3 };
	m[5] = new int[] { 21, 22, 23, 24 ,5,2};
	print(m);
	//Console.WriteLine("==========");
	print(rotate(m));
}

int[][] rotate(int[][] m)
{
	int l = m.Length;
	int temp = m[0][0];
	int i = 0;
	int next;
	int layers = m.Length / 2;
	for (int offset = 0; offset < layers; offset++)
	{
		l--;
		for (i = offset; i < l; i++)
		{
			//from top to right
			next = m[i][l];
			m[i][l] = temp;
			temp = next;

			//from  right to bottom
			next = m[l][l - i + offset];
			m[l][l - i + offset] = temp;
			temp = next;

			//from bottom to left
			next = m[l - i+ offset][offset];
			m[l - i+ offset][offset] = temp;
			temp = next;

			//from left to top
			next = m[offset][i];
			m[offset][i] = temp;

			//print(m);
			temp = m[offset][i + 1];
		}
		temp = m[offset + 1][offset + 1];		
	}
	return m;
}

void print(int[][] m)
{
	Console.WriteLine("==============================");
	for (int y = 0; y < m.Length; y++)
	{
		for (int x = 0; x < m[y].Length; x++)
		{
			Console.Write(m[y][x].ToString().PadLeft(2, '0') + "   ");
		}
		Console.WriteLine();
	}
}
// Define other methods and classes here