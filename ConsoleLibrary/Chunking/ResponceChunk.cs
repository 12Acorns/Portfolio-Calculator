using CalculatorLibrary.Operators;

namespace CalculatorLibrary.Chunking
{
    public record ResponceChunk(
		decimal _leftInput,
		decimal _rightInput,
		Operator _operator);
}
