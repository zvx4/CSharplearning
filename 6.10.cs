class Myclass
{
	public int Sum(int x,int y)
    {
        return x + y;
    }

    public float Aver(float x, float y)
    {
        return (x + y) / 2;
    }
}

class MainProgram
{
    static void Main()
    {
        Myclass mc = new Myclass();
        int input1 = 5, input2 = 12;
        Console.WriteLine("Sum:{0}", mc.Sum(input1,input2));
        Console.WriteLine("Average:{0}", mc.Aver(input1, input2));
    }
}