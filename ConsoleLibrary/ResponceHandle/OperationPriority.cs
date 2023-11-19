using CalculatorLibrary.Chunking;
using CalculatorLibrary.Operators;

namespace CalculatorLibrary.ResponceHandle
{
	public partial class OperationPriority(ResponceChunk[] _chunks)
	{
		public ResponceChunk[] SortOperators()
		{
			for (int i = 0; i < _chunks.Length; i++)
			{
				int _baseOperatorPriority = GetPriority(_chunks[i]);
				for (int j = 0; j < _chunks.Length - i; j++)
				{
					int _index = i + j;
					int _currentOperatorPriority = GetPriority(_chunks[_index]);
					
					if(_baseOperatorPriority < _currentOperatorPriority)
					{
						ResponceChunk _tempChunk = _chunks[i];
						_chunks[i] = _chunks[_index];
						_chunks[_index] = _tempChunk;
						_baseOperatorPriority = GetPriority(_chunks[i]);
					}
				}
			}
			return _chunks;
		}
		private static int GetPriority(ResponceChunk _chunk)
		{
			int _value = OrderOfOperation.
				OperatorPriority[
				OperatorTypeCasting.GetOperatorFromCast(_chunk._operator.Type)];
			return _value;
		}
	}
}
