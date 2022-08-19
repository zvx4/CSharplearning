class Myclass
{
	public int GetHour()
    {
        DateTime dt = DateTime.Now;
        int Hour = dt.Hour;
        return Hour;
    }
}

class MainProgram
{
    static void Main()
    {
        Myclass mc = new Myclass();
        Console.WriteLine("Hour:{0}", mc.GetHour());
    }
}