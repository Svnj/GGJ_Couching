using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardPool : MonoBehaviour
{
	private IList<CardSoul> cards;


	void Awake()
	{
		cards = GetComponents<CardSoul>();
	}

	public CardSoul GetCard()
	{
		int randomIndex = Fortuneteller.GiveItToMeRandom(cards.Count);
		CardSoul yourNewCard = cards[randomIndex];
		cards.RemoveAt(randomIndex);
		return yourNewCard;
	}
}
