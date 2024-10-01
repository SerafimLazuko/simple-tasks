using System;
using System.Collections.Generic;

//Даны три неубывающих массива чисел. Найти число, которое присутствует во всех трех массивах.
//Input: [1,2,4,5], [3,3,4], [2,3,4,5,6]
//Output: 4

public class Program
{
	public static void Main()
	{
		int[] arr1 = new int[4]{1,2,4,5};
		int[] arr2 = new int[3]{3,3,4};
		int[] arr3 = new int[5]{2,3,4,5,6};
		
		List<int[]> arrays = new List<int[]>();
		arrays.Add(arr1);
		arrays.Add(arr2);
		arrays.Add(arr3);
		
		Console.WriteLine(CommonNum(arrays));
	}
	
	public static int CommonNum(List<int[]> arrays)
	{
		var hashSetIntersetcResult = new HashSet<int>(arrays[0]);
		
		foreach(var arr in arrays)
		{
			hashSetIntersetcResult.IntersectWith(arr);
		}
		
		var enumerator = hashSetIntersetcResult.GetEnumerator();
		enumerator.MoveNext();
		
		return hashSetIntersetcResult.Count > 0 ? enumerator.Current : 0;
	}
}
