using UnityEngine;
using System.Collections;

public class Telekinesis : CardSoul {

	void Start()
	{
		cardName = "Telekinesis";
		power = "";
		risk = "";
		fail = "";
		
		Effect powerEff = Effect.MOVE_REMOTE;
		Effect riskEff = Effect.MOVE_REMOTE;
		Effect failEff = Effect.NONE;
		
		p = 30;
		r = 20;
		f = 50;

		moveDist = 1;
	}

}
