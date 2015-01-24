using UnityEngine;
using System.Collections;

public class Banana on shoelace : CardSoul {

	void Start()
	{
		cardName = "Banana on shoelace";
		power = "";
		risk = "";
		fail = "";
		
		Effect powerEff = Effect.MOVE_REMOTE;
		Effect riskEff = Effect.PLAY_AGAIN;
		Effect failEff = Effect.NONE;
		
		p = 50;
		r = 50;
		f = 0;

		moveDist = 3;
	}

}
