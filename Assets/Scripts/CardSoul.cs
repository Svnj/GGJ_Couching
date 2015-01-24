using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CardSoul : MonoBehaviour, IPointerDownHandler
{

	#region events

	public delegate void PlayAction();
	public delegate void PlayActionWithParam(int i);
	public delegate void ClickAction(CardSoul card);
	public event PlayAction _currentEvent;
	public event PlayActionWithParam _currentEventParam;

	public static event ClickAction OnClick;

	public static event PlayAction OnDoNothing;
	public static event PlayAction OnCutTable;
	public static event PlayAction OnTapeTable;

	public static event PlayActionWithParam OnNewCard;
	public static event PlayActionWithParam OnIWait;
	public static event PlayActionWithParam OnYouWait;
	public static event PlayActionWithParam OnMoveToMe;
	public static event PlayActionWithParam OnMoveAway;

	public void DoSomething(){ if(_currentEvent != null) _currentEvent();}
	public void DoSomethingWithParam(int i){ if(_currentEventParam != null) _currentEventParam(i);}
	public void Click(){if(OnClick!=null) OnClick(this);}

	#endregion

	#region attributes

	[SerializeField] protected string cardName;
	[SerializeField] protected string power;
	[SerializeField] protected string risk;
	[SerializeField] protected string fail;

	[SerializeField] protected Effect powerEff = Effect.NONE;
	[SerializeField] protected Effect riskEff = Effect.NONE;
	[SerializeField] protected Effect specialEff = Effect.NONE;
	[SerializeField] protected Effect failEff = Effect.NONE;

	[SerializeField] protected int p = 100,r = 0, s = 0,f = 0;

	[SerializeField] protected int moveDist = 1;
	[SerializeField] protected int waitTurns = 1;
	[SerializeField] protected int numbCards = 1;

	#endregion

	protected Effect activeEffect = Effect.NONE;


	public enum Effect
		{
			NONE,
			NEW_CARD,
			MOVE_TO_ME,
			MOVE_AWAY,
			GAME_OVER,
			CUT_TABLE,
			WAIT,
			MAKE_WAIT,
			FIX_TABLE
		}

	// Use this for initialization
	void Start ()
	{ 
		Text text = GetComponent<Text>();
		text.text = cardName;
	}

	public void Play()
	{
		WhatHappens();
		MakeItHappen();
	}

	public void OnPointerDown(PointerEventData eventData)
	{
		Click();
	}

	protected virtual void WhatHappens()
	{
		int destiny = Fortuneteller.ReadTheSigns(p,r,s,f);
		
		switch (destiny)
		{
		default: activeEffect = failEff; break;
		case (0): activeEffect = powerEff; break;
		case (1): activeEffect = riskEff; break;
		case (2): activeEffect = specialEff; break;
		}
	}

	protected void MakeItHappen()
	{
		switch(activeEffect)
		{
			default: break;
			case(Effect.NONE):
				_currentEvent = OnDoNothing; break;
			case(Effect.NEW_CARD):
			_currentEventParam = OnNewCard; DoSomethingWithParam(numbCards); break;
			case(Effect.MOVE_TO_ME): 
				_currentEventParam = OnMoveToMe; DoSomethingWithParam(moveDist); break;
			case(Effect.MOVE_AWAY): 
				_currentEventParam = OnMoveAway; DoSomethingWithParam(moveDist); break;
			case(Effect.GAME_OVER):
				 break;
			case(Effect.CUT_TABLE): 
				_currentEvent = OnCutTable; break;
			case(Effect.FIX_TABLE): 
				_currentEvent = OnTapeTable; break;
			case(Effect.WAIT): 
				_currentEventParam = OnIWait; DoSomethingWithParam(waitTurns); break;
			case(Effect.MAKE_WAIT):
				_currentEventParam = OnYouWait; DoSomethingWithParam(waitTurns); break;
		}

		DoSomething();
	}
}
