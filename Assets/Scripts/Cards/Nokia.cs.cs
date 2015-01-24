using UnityEngine;
using System.Collections;

public class Nokia : CardSoul {

	void Start()
	{
		cardName = "Nokia";
		power = "Throw at other Dude, to stop him for 2 rounds from taking the f-ing remote";
		risk = "";
		fail = "";
		
		Effect powerEff = Effect.PLAY_AGAIN;
		Effect riskEff = Effect.GAME_OVER;
		Effect failEff = Effect.NONE;
		
		p = 40;
		r = 10;
		f = 50;

		moveDist = 1;
	}

}
