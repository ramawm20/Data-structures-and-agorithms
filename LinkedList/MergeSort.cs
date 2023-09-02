using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
	public class MergeSort
	{
		public static void MergeSortAlgo(int[] arr)
		{
			if (arr.Length > 1)
			{
				int mid = arr.Length / 2;
				int[] left = new int[mid];
				int[] right = new int[arr.Length - mid];

				
				for (int i = 0; i < mid; i++)
					left[i] = arr[i];

				for (int i = mid; i < arr.Length; i++)
					right[i - mid] = arr[i];

				MergeSortAlgo(left);
				MergeSortAlgo(right);

				Merge(left, right, arr);
			
			
		}
	}
		public static void Merge(int[] left, int[] right, int[]arr)
		{
			int i = 0;
			int j = 0;
			int k = 0;
			while (i< left.Length && j<right.Length)
			{
				if (left[i] <= right[j])
				{
					arr[k] = left[i];
					i++;
				}
				else
				{
					arr[k] = right[j];
					j++;
				}
				k++;
			}
			while (i < left.Length)
			{
				arr[k] = left[i];
				i++;
				k++;
			}

			
			while (j < right.Length)
			{
				arr[k] = right[j];
				j++;
				k++;
			}

		}
	}
}
