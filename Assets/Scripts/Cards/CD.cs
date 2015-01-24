using UnityEngine;
using System.Collections;

public class CD : CardSoul {

	void Start()
	{
		cardName = "CD";
		power = "";
		risk = "";
		fail = "";
		
		Effect powerEff = Effect.PLAY_AGAIN;
		Effect riskEff = Effect.NONE;
		Effect failEff = Effect.NONE;
		
		p = 50;
		r = 0;
		f = 50;

		moveDist = 1;
	}

}
