using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CardPool : MonoBehaviour
{
	[SerializeField] private List<CardSoul> cards;


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
		int randomIndex = Fortuneteller.GiveItToMeRandom(cards.Count);
		CardSoul yourNewCard = cards[randomIndex];
		cards.RemoveAt(randomIndex);
		return yourNewCard;
	}
}
