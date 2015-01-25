using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Babo : MonoBehaviour
{
	public Player Bill;
	public Player Bob;
	Player activePlayer;

	[SerializeField] private CardPool couch = null;
	[SerializeField] private Table table = null;

	public bool KIisPlaying;

	public Text comment;
	public Text description;

	public bool gameOver;

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
			Bill.ReceiveCard(couch.GetCard(), true);
			Bob.ReceiveCard(couch.GetCard(), false);
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
		CardSoul.OnCardPlayed += DropPlayedCard;
		CardSoul.OnMouseHover += ShowCardDescription;

		Table.OnGameOver += GameOver;
		CardPool.OnGameOver += GameOver;
	}

	public void ShowCardDescription(CardSoul card)
	{
		description.text = card.cardName;
	}

	public void CardClick(CardSoul card)
	{		

		if(KIisPlaying)
		{
			card = activePlayer.GetRandomCard();
			card.Play();
		}

		card.Play();


		activePlayer.numOfTurnsLeft--;
		if(activePlayer.numOfTurnsLeft < 0)
		{
			activePlayer.numOfTurnsLeft = 0;
		}

		// switch to KI
//		if(activePlayer == Bill && activePlayer.numOfTurnsLeft == 0)
//		{
//			SwitchPlayer();
//		}

		if(activePlayer.GetNumberOfCards() == 0)
		{
			Debug.Log( activePlayer + "take card on empty hand");
			activePlayer.ReceiveCard(couch.GetCard(), activePlayer==Bill);
			activePlayer.numOfTurnsLeft = 0;
		}

		if(activePlayer.numOfTurnsLeft == 0)
		{
			SwitchPlayer();
			if(activePlayer == Bob)
			{
				KIisPlaying = true;
				StartCoroutine( "Wait");
			}
			else
			{
				KIisPlaying = false;
			}
		}
//		if(KIisPlaying && activePlayer.numOfTurnsLeft > 0)
//		{
//			StartCoroutine( "Wait");
//		}
	}

	IEnumerator Wait() {
		yield return new WaitForSeconds(1f);
		CardClick(null);
	}
	
	public void SwitchPlayer()
	{
		if(activePlayer == Bill)
		{
			activePlayer = Bob;
			Bob.numOfTurnsLeft = 1;
		}
		else
		{
			activePlayer = Bill;
			Bill.numOfTurnsLeft = 1;
		}
	}

	public void DropPlayedCard(CardSoul card)
	{
		//Debug.Log( activePlayer + "Drop Card");
		activePlayer.DropCard(card);
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
				Bill.ReceiveCard(couch.GetCard(),true);
			}
		}
		else
		{
			for(int i=0; i<count; i++)
			{
				Bob.ReceiveCard(couch.GetCard(),false);
			}
		}
	}

	public void GameOver()
	{
		comment.text = "Game over!!!";
	}
}
