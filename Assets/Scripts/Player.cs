using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour {

	public int numOfTurnsLeft = 1;

	private Vector3 leftPosition = new Vector3(-0.64f,0.78f,1.72f);
	private Vector3 spacing = new Vector3(0.1f,0,0.3f);
	private Vector3 toOtherCouch = new Vector3 (1.3f,0,0);

	List<CardSoul> cards;
 
	public void GetReady()
	{
		cards = new List<CardSoul>();
	}

	
	public int GetNumberOfCards()
	{
		return cards.Count;
	}

	public void ReceiveCard(CardSoul card, bool player)
	{
		cards.Add(card);
		Vector3 newPosition = leftPosition - (cards.Count-1) * spacing;
		if(!player)
		{
			newPosition += (toOtherCouch + (cards.Count-1) * new Vector3(0.2f,0,0));
		}
		card.transform.position = newPosition;
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
