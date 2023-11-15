using System.Text.RegularExpressions;
using ConsoleLibrary.ResponceTypes;

namespace ConsoleLibrary.Chunking
{
    public partial class Chunkator(string _input)
    {
        public string Input { get; internal init; } = _input;

        public ResponceChunk[]? Chunkate()
        {
            string[] _validOperators = new ValidOperators().operators;
            List<ResponceChunk> _chunks = [];

            Span<string> _split = Split().Split(_input);

			if (_split[0] == Input) return null;

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
	                    _validOperators[j]));
				}
			}
            return [.. _chunks];
        }

		[GeneratedRegex(@"([*()\^\/]|(?<!E)[\+\-])")]
		private static partial Regex Split();
	}
}
