using UnityEngine;
using System.Collections;

public class Card1 : CardSoul {

	void Start()
	{
		cardName = "";
		power = "";
		risk = "";
		fail = "";
		
		Effect powerEff = Effect.NONE;
		Effect riskEff = Effect.NONE;
		Effect failEff = Effect.NONE;
		
		p = 1;
		r = 0;
		f = 0;
	}

}
