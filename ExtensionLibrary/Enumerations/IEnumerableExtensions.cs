﻿using System.Collections.Generic;

namespace ExtensionLibrary.Enumerations
{
    public static class IEnumerableExtensions
    {
		public static IEnumerable<(T item, int index)> WithIndex<T>(this IEnumerable<T> self) => 
			self?.Select((item, index) => (item, index)) ?? Enumerable.Empty<(T, int)>();
	}
}