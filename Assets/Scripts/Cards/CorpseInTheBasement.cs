using UnityEngine;
using System.Collections;

public class Corpse in the basement : CardSoul {

	void Start()
	{
		cardName = "Corpse in the basement";
		power = "";
		risk = "";
		fail = "";
		
		Effect powerEff = Effect.MOVE_REMOTE;
		Effect riskEff = Effect.MOVE_REMOTE;
		Effect failEff = Effect.NONE;
		
		p = 50;
		r = 50;
		f = 0;

		moveDist = 1;
	}

}
