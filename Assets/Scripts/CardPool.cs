using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardPool : MonoBehaviour
{
	[SerializeField] private List<CardSoul> cards;


	public delegate void GameOverAction();
	public static event GameOverAction OnGameOver;

	public void GameOver(){if(OnGameOver!=null) OnGameOver();}

	void Awake()
	{
		cards = new List<CardSoul>();
		foreach(CardSoul card in GetComponentsInChildren<CardSoul>())
		{
			cards.Add(card);
		}
	}

	public CardSoul GetCard()
	{
		if (cards.Count < 1)
		{
			//TODO game over
			Debug.Log ("game over");
			GameOver();
			return null;
		}
		int randomIndex = Fortuneteller.GiveItToMeRandom(cards.Count);
		CardSoul yourNewCard = cards[randomIndex];
		cards.RemoveAt(randomIndex);
		return yourNewCard;
	}
}
