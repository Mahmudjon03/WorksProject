Console.ForegroundColor = ConsoleColor.Red;
int n = 1, b = 10;
for (int i = 0; i < 10; i++)
{
	
	for (int j = 1; j < b; j++)
	{
        Console.Write(" ");
    }
	for (int k = 1; k < n; k++)
	{
		Console.Write("*");
	}
	for(int t = 0; t < b-1; t++)
	{
		Console.Write(" ");
	}
    for (int j = 0; j < b; j++)
    {
        Console.Write(" ");
    }
    for (int k = 1; k < n; k++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
    n = n + 2;
	b--;
}
int h =38, l=1;
for (int i = 0; i < 20; i++)
{
    for (int k = 1; k < l; k++)
    {
        Console.Write(" ");
    }

    for (int j = 1; j < h; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
    h=h-2;
    l++;
}