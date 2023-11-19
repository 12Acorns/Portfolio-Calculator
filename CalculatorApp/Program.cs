using CalculatorLibrary.ResponceHandle;
using CalculatorLibrary.Chunking;

namespace CalculatorApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Chunkator _chunkator = new("2*4^2");
			var _chunks = _chunkator?.Chunkate();

			for (int i = 0; i < _chunks?.Length; i++)
			{
				Console.Write($"{_chunks[i]?._leftInput}" +
					$"{_chunks[i]?._operator.Type}" +
					$"{_chunks[i]?._rightInput}\n");
			}
			Console.WriteLine();

			Console.Write("\n");

			ResponceChunk[] _priority = new OperationPriority(_chunks!).SortOperators();

			for (int i = 0; i < _priority?.Length; i++)
			{
				Console.Write($"{_priority[i]?._leftInput}" +
					$"{_priority[i]?._operator.Type}" +
					$"{_priority[i]?._rightInput}\n");
			}
			Console.WriteLine();
			Console.WriteLine("Expected: \n" +
				"1/2\n" +
				"2*4\n" +
				"11+1\n" +
				"1-1\n" +
				"4+1\n");

			decimal[] _values = new decimal[_priority!.Length];
			for (int i = 0; i < _values?.Length; i++)
			{
				_values[i] = EquationSolver.AddChunk(_priority[i]);
				Console.Write(_values[i] + "\n");

				if (i + 1 > _priority.Length - 1) continue;

				_priority[i + 1] = EquationSolver.ReplaceFirstChunkValue(_values[i], _priority[i+1]);
			}
			Console.WriteLine();
			Console.ReadLine();
		}
	}
}
