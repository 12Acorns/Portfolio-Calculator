namespace ConsoleLibrary.Operators
{
	public static class OrderOfOperation
	{
		public static Dictionary<OperatorType, int> OperatorPriority => new()
		{
			{ OperatorType.LeftBracket, 3 },
			{ OperatorType.RightBracket, 3 },
			{ OperatorType.Indice, 2 },
			{ OperatorType.Division, 1 },
			{ OperatorType.Multiplication, 1 },
			{ OperatorType.Subtraction, 0 },
			{ OperatorType.Addition, 0 }
		};
	}
}
