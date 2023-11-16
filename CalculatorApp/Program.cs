using ConsoleLibrary.ResponceHandle;
using ConsoleLibrary.Chunking;

namespace CalculatorApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Chunkator _chunkator = new("11+1-1/2*4+1");
			var _chunks = _chunkator.Chunkate();

			for (int i = 0; i < _chunks!.Length; i++)
			{
				Console.Write($"{_chunks[i]._leftInput}" +
					$"{_chunks[i]._operator.Type}" +
					$"{_chunks[i]._rightInput}\n");
			}
			Console.WriteLine();

			Console.Write("\n");

			ResponceChunk[] _priority = new OperationPriority(_chunks!).SortOperators();

			for (int i = 0; i < _priority.Length; i++)
			{
				Console.Write($"{_priority[i]._leftInput}" +
					$"{_priority[i]._operator.Type}" +
					$"{_priority[i]._rightInput}\n");
			}
			Console.WriteLine();
			Console.ReadLine();
		}
	}
}
