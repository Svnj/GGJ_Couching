using UnityEngine;
using System.Collections;

public class FishingPole : CardSoul {

	void Start()
	{
		cardName = "Fishing pole";
		power = "";
		risk = "";
		fail = "";
		
		Effect powerEff = Effect.MOVE_REMOTE;
		Effect riskEff = Effect.PLAY_AGAIN;
		Effect riskEff2 = Effect.NEW_CARD;
		Effect failEff = Effect.NONE;

		p = 30;
		r = 30;
		s = 20;
		f = 20;

		moveDist = 2;
	}

}
