using UnityEngine;
using System.Collections;

public class Babo : MonoBehaviour
{
	public Player Bill;
	public Player Bob;
	Player activePlayer;

	[SerializeField] private CardPool couch = null;
	[SerializeField] private Table table = null;


	// Use this for initialization
	void Start ()
	{
		//TODO make starting player random
		activePlayer = Bill;
		Bill.numOfTurnsLeft = 1;

		Bill.GetReady();
		Bob.GetReady();

		// give starting cards
		for(int i = 0; i<3; i++)
		{
			Bill.ReceiveCard(couch.GetCard());
			Bob.ReceiveCard(couch.GetCard());
		}

		// listen to card events
		CardSoul.OnDoNothing += DoNothing;
		CardSoul.OnCutTable += CutTable;
		CardSoul.OnIWait += PauseForMe;
		CardSoul.OnYouWait += PauseForYou;
		CardSoul.OnTapeTable += TapeTable;
		CardSoul.OnMoveToMe += MoveRemoteToMe;
		CardSoul.OnMoveAway += MoveRemoteToYou;
		CardSoul.OnNewCard += GiveCard;

		CardSoul.OnClick += CardClick;
	}

	public void CardClick(CardSoul card)
	{
		if(activePlayer.numOfTurnsLeft == 0)
		{
			SwitchPlayer();
		}

		card.Play();
		activePlayer.numOfTurnsLeft--;
		if(activePlayer.numOfTurnsLeft < 0)
		{
			activePlayer.numOfTurnsLeft = 0;
		}
	}

	public void SwitchPlayer()
	{
		if(activePlayer == Bill)
		{
			activePlayer = Bob;
		}
		else
		{
			activePlayer = Bill;
		}
	}

	public void DoNothing ()
	{
		Debug.Log( activePlayer + "Do nothing");
	}

	public void CutTable()
	{
		Debug.Log( activePlayer + "Cut Table");
		table.CutMeDown(activePlayer == Bill);
	}

	public void TapeTable()
	{
		Debug.Log( activePlayer + "Tape Table");
		table.TapeMeUp(activePlayer == Bill);
	}

	public void MoveRemoteToMe(int dist)
	{
		Debug.Log( activePlayer + "Move Remote to me " + dist);
		if(activePlayer == Bill)
		{
			table.MoveToBill(dist);
		}
		else
		{
			table.MoveToBob(dist);
		}
	}

	public void MoveRemoteToYou(int dist)
	{
		Debug.Log( activePlayer + "Move Remote away " + dist);
		if(activePlayer == Bob)
		{
			table.MoveToBill(dist);
		}
		else
		{
			table.MoveToBob(dist);
		}
	}

	public void PauseForMe(int turns)
	{
		Debug.Log( activePlayer + "Pause for me " + turns);
		if(activePlayer == Bill)
		{
			Bill.numOfTurnsLeft = 0;
			Bob.numOfTurnsLeft = turns;
		}
		else
		{
			Bob.numOfTurnsLeft = 0;
			Bill.numOfTurnsLeft = turns;
		}
	}

	public void PauseForYou(int turns)
	{
		Debug.Log( activePlayer + "Pause for you " + turns);
		if(activePlayer == Bob)
		{
			Bill.numOfTurnsLeft = 0;
			Bob.numOfTurnsLeft = turns;
		}
		else
		{
			Bob.numOfTurnsLeft = 0;
			Bill.numOfTurnsLeft = turns;
		}
	}

	public void GiveCard(int count)
	{
		Debug.Log( activePlayer + "New Card " + count);
		if (activePlayer == Bill)
		{
			for(int i=0; i<count; i++)
			{
				Bill.ReceiveCard(couch.GetCard());
			}
		}
		else
		{
			for(int i=0; i<count; i++)
			{
				Bob.ReceiveCard(couch.GetCard());
			}
		}
	}


	// Update is called once per frame
	void Update () {
	
	}


}
