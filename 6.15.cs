using System;

class Class1
{
	public void ListInts(params int[] inVals ) //声明一个输入参数为数组的方法
	{
        if ((inVals != null) && (inVals.Length != 0)) //一旦输入不为零且其长度不为零
            for (int i=0; i<inVals.Length; i++)
            {
				inVals[i] = inVals[i] * 10;
				Console.WriteLine($"{inVals[i]}"); //将每个数组的元素乘10并输出
            }
	}
}

class Program
{
	static void Main()

    {
		int first = 5, second = 6, third = 7;//声明三个整数

		Class1 c1= new();
		c1.ListInts(first, second ,third); //调用方法

		Console.WriteLine($"{first},{second},{third}"); //将其输出
    }
}