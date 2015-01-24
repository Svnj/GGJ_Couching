using UnityEngine;
using System.Collections;

public class TractorBeam : CardSoul {

	void Start()
	{
		cardName = "Tractor beam";
		power = "";
		risk = "";
		fail = "";
		
		Effect powerEff = Effect.MOVE_REMOTE;
		Effect riskEff = Effect.WAIT;
		Effect failEff = Effect.NONE;
		
		p = 100;
		r = 100;
		f = 0;

		moveDist = 2;
	}

}
