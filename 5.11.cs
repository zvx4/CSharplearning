class DayTemp
{
	public int High, Low;
	public int Average()
    {
		return (High + Low) / 2;
    }
}

class Program
{
	static void Main()
    {
		DayTemp d1 = new DayTemp();
		DayTemp d2 = new DayTemp();
		d1.High = 855; d1.Low = 566;
		d2.High = 932; d2.Low = 423;
		Console.WriteLine($"d1:{d1.High},{d1.Low},{d1.Average()}");
		Console.WriteLine($"d2:{d2.High},{d2.Low},{d2.Average()}");
	}
}