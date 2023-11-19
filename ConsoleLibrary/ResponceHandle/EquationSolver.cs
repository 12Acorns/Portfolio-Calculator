using CalculatorLibrary.Chunking;
using CalculatorLibrary.Operators;

namespace CalculatorLibrary.ResponceHandle
{
	public static partial class EquationSolver
	{
		public static decimal AddChunk(ResponceChunk _chunk)
		{
			switch(OperatorTypeCasting.GetOperatorFromCast(_chunk._operator.Type))
			{
				case OperatorType.Addition:
					return _chunk._leftInput + _chunk._rightInput;
				case OperatorType.Subtraction:
					return _chunk._leftInput - _chunk._rightInput;
				case OperatorType.Multiplication:
					return _chunk._leftInput * _chunk._rightInput;
				case OperatorType.Division:
					return _chunk._leftInput / _chunk._rightInput;
				case OperatorType.Indice:
					return (decimal)Math.Pow((double)_chunk._leftInput, (double)_chunk._rightInput);
				default:
					return -1;
			}
		}
		public static ResponceChunk ReplaceFirstChunkValue(decimal _value, ResponceChunk _chunk)
		{
			return new ResponceChunk(_value, _chunk._rightInput, _chunk._operator);
		}
	}
}
