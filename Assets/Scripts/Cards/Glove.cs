using UnityEngine;
using System.Collections;

public class Glove : CardSoul {

	void Start()
	{
		cardName = "Glove";
		power = "Draw 2 Cards";
		risk = "";
		fail = "";
		
		Effect powerEff = Effect.NEW_CARD;
		Effect riskEff = Effect.NONE;
		Effect failEff = Effect.NONE;
		
		p = 100;
		r = 0;
		f = 0;

		moveDist = 1;
	}

}
