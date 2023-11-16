using ConsoleLibrary.Operators;

namespace ConsoleLibrary.Chunking
{
    public record ResponceChunk(
		int _leftInput,
		int _rightInput,
		Operator _operator);
}
