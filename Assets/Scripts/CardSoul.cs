using UnityEngine;
using System.Collections;

public class CardSoul : MonoBehaviour {

	protected string cardName;
	protected string power;
	protected string risk;
	protected string fail;

	protected Effect powerEff = Effect.NONE;
	protected Effect riskEff = Effect.NONE;
	protected Effect failEff = Effect.NONE;

	protected int p = 1,r = 0,f = 0;

	protected int moveDist = 1;

	protected Effect activeEffect = Effect.NONE;


	public enum Effect
		{
			NONE,
			NEW_CARD,
			PLAY_AGAIN,
			MOVE_REMOTE,
			GAME_OVER,
			CUT_TABLE
		}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Play()
	{
		WhatHappens();

		MakeItHappen();
	}

	private void WhatHappens()
	{
		int destiny = Fortuneteller.ReadTheSigns(p,r,f);
		
		switch (destiny)
		{
		default: activeEffect = failEff; break;
		case (0): activeEffect = powerEff; break;
		case (1): activeEffect = riskEff; break;
		}
	}

	private void MakeItHappen()
	{
		switch(activeEffect)
		{
			default: break;
			case(Effect.NONE): break;
			case(Effect.NEW_CARD): break;
			case(Effect.PLAY_AGAIN): break;
			case(Effect.MOVE_REMOTE): break;
			case(Effect.GAME_OVER): break;
			case(Effect.CUT_TABLE): break;
		}
	}
}
