using UnityEngine;
using System.Collections;

public class Dukttape : CardSoul {

	void Start()
	{
		cardName = "Dukttape";
		power = "";
		risk = "";
		fail = "";
		
		Effect powerEff = Effect.FIX_TABLE;
		Effect riskEff = Effect.WAIT;
		Effect failEff = Effect.NONE;
		
		p = 40;
		r = 20;
		f = 40;

		moveDist = 1;
	}

}
