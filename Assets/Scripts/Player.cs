using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour {

	public int numOfTurnsLeft = 1;

	List<CardSoul> cards;
 
	public void GetReady()
	{
		cards = new List<CardSoul>();
	}

	
	public int GetNumberOfCards()
	{
		return cards.Count;
	}

	public void ReceiveCard(CardSoul card)
	{
		cards.Add(card);
	}

	public void DropCard(CardSoul card)
	{
		//Debug.Log("drop " + card);
		card.gameObject.SetActive(false);
		cards.Remove(card);
	}

	public CardSoul GetRandomCard()
	{
		if (cards.Count < 1)
		{
			return null;
		}
		int randomIndex = Fortuneteller.GiveItToMeRandom(cards.Count);
		CardSoul yourChosenCard = cards[randomIndex];
		cards.RemoveAt(randomIndex);
		return yourChosenCard;
	}

}
