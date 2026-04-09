class Calculator
{
	static void Main(string[] agrs)
	{
		int a = 10;
		int b = 6;
		
		console.WriteLine("Hasil Penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b));
		console.WriteLine("Hasil Pengurangan: {0} - {1} = {2}", a, b, Penambahan(a, b));
		
		Console.WriteLine("\nTekan sembarang key untuk keluar");
		Console.ReadKey)();
	}
	
	static int Penambahan(int a, int b)
	{
		return a + b;
	}
	
	static int Pengurangan(int a, int b)
	{
		return a - b;
	}
}
