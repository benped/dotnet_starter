using System;
using System.Linq;

public class Kata
{
  public static int PositiveSum(int[] arr)
  {
    // Your code here
    int total = 0;
    foreach( int i in arr){
      if(i > 0){
        total += i;
      }
    }
    return total;
  }
}
