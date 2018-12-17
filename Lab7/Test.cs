using System;

/// <summary>
///    Test harness.
/// </summary>

public class Test
{
	public static void Main()
	{
		// int i = 0;
  //       ulong ul = 0;
  //       string s = "Test";
	 //    Console.WriteLine(Utils.Utils.IsItFormattable(i));
  //       Console.WriteLine(Utils.Utils.IsItFormattable(ul));
  //       Console.WriteLine(Utils.Utils.IsItFormattable(s));
	    int num = 65;
        string msg = "A string";
        Utils.Coordinate c = new Utils.Coordinate(21.0, 68.0);
        Utils.Utils.Display(num);
        Utils.Utils.Display(msg);
        Utils.Utils.Display(c);
    }
}
