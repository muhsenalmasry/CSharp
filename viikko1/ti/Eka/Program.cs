using System;

namespace Eka
{
    class Program
    {
        static void Main(string[] args)
        {
	    if(args.Length != 0)
	    {
		    if(args.Length == 1)
		    {
			for(int i=0; i<int.Parse(args[0]); i++)
		    	{
            			Console.WriteLine("Tämä on C#-kurssin eka harjoitus");
	    	    	}
		    }
		    else if(args.Length == 2)
		    {
				for(int i=0; i<int.Parse(args[0]); i++)
		    		{
					for(int j=0; j<int.Parse(args[1]); j++)
						Console.Write(" ");
            				Console.WriteLine("Tämä on C#-kurssin eka harjoitus");
	    	    		}
		    }
		    else if(args.Length == 3)
		    {
				for(int i=0; i<int.Parse(args[0]); i++)
		    		{
					for(int j=0; j<int.Parse(args[1]); j++)
						Console.Write(" ");
            				Console.WriteLine(args[2]);
	    	    		}
		    }
	    }
	    else
	    {
		    for(int i=0; i<5; i++)
		    {
            		Console.WriteLine("Tämä on C#-kurssin eka harjoitus");
	    	    }
	    }
        }
    }
}
