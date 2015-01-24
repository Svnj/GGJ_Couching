using UnityEngine;
using System.Collections;

public class Hoofmagnet : CardSoul {

	void Start()
	{
		cardName = "Hoofmagnet";
		power = "";
		risk = "";
		fail = "";
		
		Effect powerEff = Effect.MOVE_REMOTE;
		Effect riskEff = Effect.NONE;
		Effect failEff = Effect.NONE;
		
		p = 100;
		r = 0;
		f = 0;

		moveDist = 1;
	}

}
