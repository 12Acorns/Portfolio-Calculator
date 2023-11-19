namespace CalculatorLibrary.Operators
{
	public readonly struct Operator(OperatorType _type)
	{
		public readonly string Type => OperatorTypeCasting.CastOperator(_type);
	}
}
