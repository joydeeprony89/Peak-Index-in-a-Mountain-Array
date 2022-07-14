using System;

namespace Peak_Index_in_a_Mountain_Array
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
  public class Solution
  {
    public int PeakIndexInMountainArray(int[] arr)
    {
      int l = 1; int r = arr.Length - 2;
      while (l <= r)
      {
        int mid = l + (r - l) / 2;
        if (arr[mid] > arr[mid - 1] && arr[mid] > arr[mid + 1]) return mid;
        else if (arr[mid] > arr[mid - 1]) l = mid + 1;
        else r = mid - 1;
      }

      return -1;
    }
  }

  public class Solution1
  {
    public int PeakIndexInMountainArray(int[] arr)
    {
      for (int i = 0; i <= arr.Length - 2; i++)
      {
        if (arr[i] > arr[i + 1]) return i;
      }
      return arr[^1];
    }
  }
}
