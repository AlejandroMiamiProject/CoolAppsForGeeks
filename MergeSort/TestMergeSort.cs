using System;
using System.Collections;

namespace MergeSort
{
  class MergeSort { 
    public static int myMax(ArrayList arr){
      int max = 0;
      foreach (var num in arr){
          if ((int)num > max){
              max = (int)num;
          }
      }
      return max;
    }

    public static int myMin(ArrayList arr){
      int min = 100000;
      foreach (var num in arr){
          if ((int)num < min){
              min = (int)num;
          }
      }
      return min;
    }

    public static ArrayList mergeSort(ArrayList arr)
    {
      ArrayList upper = new ArrayList();
      ArrayList lower = new ArrayList();
      while(arr.Count > 1){
        int a = myMax(arr);
        int b = myMin(arr);
        upper.Add(a); 
        lower.Add(b);
        arr.Remove(a);
        arr.Remove(b);
      }
      if(arr.Count == 1){
        lower.Add(arr[0]);
      }
      upper.Reverse();
      lower.AddRange(upper);
      return lower;
    }

    public static void Main(string[] args)
    {
      Random rnd = new Random();
      ArrayList test = new ArrayList();

      Console.WriteLine("Unsorted: ");
      for(int i = 0; i < 5; i++){
        test.Add(rnd.Next(1, 20));
        Console.Write(test[i] + ", ");
      }
      
      Console.WriteLine("\nSorted: ");
      test = mergeSort(test);
      for(int i = 0; i < 5; i++){
        Console.Write(test[i] + ", ");
      }
    }
  }
}
