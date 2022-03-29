public class Kata
{
  public static bool Check(object[] a, object x)
  {
    bool check = false;
    for (int i = 0; i < a.Length; i++) {
      if(a[i].Equals(x))
      check = true;
    }
    return check; 
    
  }
}