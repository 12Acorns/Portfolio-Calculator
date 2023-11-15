using ConsoleLibrary.Chunking;

namespace CalculatorApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Chunkator _chunkator = new("1+1-1/2*4+1");
			_chunkator.Chunkate();
		}
	}
}
