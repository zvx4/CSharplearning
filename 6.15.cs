using System;

class Class1
{
	public void ListInts(params int[] inVals )
	{
        if ((inVals != null) && (inVals.Length != 0))
            for (int i=0; i<inVals.Length; i++)
            {
				inVals[i] = inVals[i] * 10;
				Console.WriteLine($"{inVals[i]}");
            }
	}
}

class Program
{
	static void Main()

    {
		int first = 5, second = 6, third = 7;

		Class1 c1= new();
		c1.ListInts(first, second ,third);

		Console.WriteLine($"{first},{second},{third}");
    }
}