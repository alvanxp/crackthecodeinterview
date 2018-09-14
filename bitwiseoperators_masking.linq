<Query Kind="Program" />

void Main()
{
	int color = ConstructColor(alpha: 255, red: 128, green: 0, blue: 14);
	Console.WriteLine("Color: "+color);
	Console.WriteLine("Red: "+GetRed(color));
}

int ConstructColor(byte alpha, byte red, byte green, byte blue)
{
	return (alpha << 24) | (red << 16) | (green << 8) | blue;
}

int GetRed(int color)
{
	return (color & 0x00FF0000) >> 16;
}
// Define other methods and classes here