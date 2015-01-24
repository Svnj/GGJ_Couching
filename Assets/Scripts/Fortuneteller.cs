using UnityEngine;
using System.Collections;

public static class Fortuneteller
{
	static System.Random rand = new System.Random();

	private static int ThrowStonesOfDestiny()
	{
		int stone = rand.Next(100);

		return stone;
	}

	public static int ReadTheSigns(int p,int r,int f)
	{
		if(p+r+f != 100)
			return -1;

		int stone = ThrowStonesOfDestiny();

		if(stone < p)
		{
			return 0;
		}
		else if(stone < p + r)
		{
			return 1;
		}
		else
		{
			return 2;
		}
	}

	public static int GiveItToMeRandom(int max)
	{
		int stone = rand.Next(max);
		
		return stone;
	}

}
