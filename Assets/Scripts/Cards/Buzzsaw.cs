using UnityEngine;
using System.Collections;

public class Buzzsaw : CardSoul {

	void Start()
	{
		cardName = "Buzzsaw";
		power = "";
		risk = "";
		fail = "";
		
		Effect powerEff = Effect.CUT_TABLE;
		Effect riskEff = Effect.WAIT;
		Effect failEff = Effect.NONE;
		
		p = 60;
		r = 40;
		f = 0;

		moveDist = 1;
	}

}
