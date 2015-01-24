using UnityEngine;
using System.Collections;

public class Treats : CardSoul {

	void Start()
	{
		cardName = "Treats";
		power = "";
		risk = "";
		fail = "";
		
		Effect powerEff = Effect.MOVE_REMOTE;
		Effect riskEff = Effect.NEW_CARD;
		Effect failEff = Effect.NONE;
		
		p = 20;
		r = 60;
		f = 20;

		moveDist = 1;
	}

}
