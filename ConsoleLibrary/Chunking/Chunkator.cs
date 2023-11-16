using ExtensionLibrary.Enumerations;
using System.Text.RegularExpressions;
using ConsoleLibrary.Operators;

namespace ConsoleLibrary.Chunking
{
    public partial class Chunkator(string _input)
    {
        public ResponceChunk[]? Chunkate()
        {
            int _operatorTypeLength = Enum.GetValues<OperatorType>().Length;

            string[] _validOperators = new string[_operatorTypeLength];

			foreach (var (_operatorType, _index) in Enum.GetValues<OperatorType>().WithIndex())
            {
                _validOperators[_index] = OperatorTypeCasting.CastOperator(_operatorType);
            }
            List<ResponceChunk> _chunks = [];

            Span<string> _split = Split().Split(_input);

			if (_split[0] == _input) throw new Exception("Please enter a valid expression.");

            for (int i = 0; i < _split.Length-1; i++)
            {
                for (int j = 0; j < _validOperators.Length; j++)
                {
                    if (_validOperators[j] != _split[i]) continue;
                    for (int k = 0; k < _validOperators.Length; k++)
                    {
                        if (i + 1 > _split.Length) continue;
                        if (_split[i + 1] != "") continue;
                        if (_validOperators[k] == _split[i + 1]) throw new Exception("Invalid Operation.");
					}

                    _chunks.Add(new ResponceChunk(
                        int.Parse(_split[i - 1]),
                        int.Parse(_split[i + 1]),
						new Operator(OperatorTypeCasting.GetOperatorFromCast(_validOperators[j]))));
                }
			}
            return [.. _chunks];
        }

		[GeneratedRegex(@"([*()\^\/]|(?<!E)[\+\-])")]
		private static partial Regex Split();
	}
}
