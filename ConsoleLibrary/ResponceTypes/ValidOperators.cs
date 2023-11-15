using System;
using System.Collections.Generic;
using System.Linq;
namespace ConsoleLibrary.ResponceTypes
{
	public readonly struct ValidOperators
	{
		public ValidOperators() { }

		public readonly string[] operators = 
		[
			"+",
			"-",
			"/",
			"*"
		];
	}
}
