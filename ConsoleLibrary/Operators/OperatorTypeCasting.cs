namespace ConsoleLibrary.Operators
{
	internal static class OperatorTypeCasting
	{
		public static string CastOperator(OperatorType _type) => _type switch
		{
			OperatorType.Addition => "+",
			OperatorType.Subtraction => "-",
			OperatorType.Division => "/",
			OperatorType.Multiplication => "*",
			OperatorType.LeftBracket => "(",
			OperatorType.RightBracket => ")",
			OperatorType.Indice => "^",

			// Invalid or unkown type
			_ => throw new ArgumentOutOfRangeException(nameof(_type), $"Not expected operator value: {_type}"),
		};
		public static OperatorType GetOperatorFromCast(string _operator) => _operator switch
		{
			"+" => OperatorType.Addition,
			"-" => OperatorType.Subtraction,
			"/" => OperatorType.Division,
			"*" => OperatorType.Multiplication,
			"(" => OperatorType.LeftBracket,
			")" => OperatorType.RightBracket,
			"^" => OperatorType.Indice,

			// Invalid or unkown type
			_ => throw new ArgumentOutOfRangeException(nameof(_operator), $"Not expected operator value: {_operator}"),
		};
	}
}
