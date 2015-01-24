using UnityEngine;
using System.Collections;

public class Book : CardSoul {

	void Start()
	{
		cardName = "Book";
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
