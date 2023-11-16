using ConsoleLibrary.Chunking;
using ConsoleLibrary.Operators;

namespace ConsoleLibrary.ResponceHandle
{
	public partial class OperationPriority(ResponceChunk[] _chunks)
	{
		/*
		 * if oper is > than oper2 we stick.
		 * if oper is < than oper2 we switch.
		 * if switch and then oper is equal to oper2 we stick.
		*/ 
		public ResponceChunk[] SortOperators()
		{
			ResponceChunk[] _sortedChunks = new ResponceChunk[_chunks.Length];
			for (int i = 0; i < _chunks.Length; i++)
			{
				int _base = GetValue(_chunks[i]);
				for (int j = 0; j < _chunks.Length; j++)
				{
					int _current = GetValue(_chunks[j]);


				}
			}
			return _sortedChunks;
		}
		private static int GetValue(ResponceChunk _chunk)
		{
			int _value = OrderOfOperation.
				OperatorPriority[
				OperatorTypeCasting.GetOperatorFromCast(_chunk._operator.Type)];
			return _value;
		}
	}
}
