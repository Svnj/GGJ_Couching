using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour {

	public int numOfTurnsLeft;

	List<CardSoul> cards;
 
	public void GetReady()
	{
		cards = new List<CardSoul>();
	}

	public void ReceiveCard(CardSoul card)
	{
		cards.Add(card);
	}

	public void PlayCard()
	{
		cards[0].Play();
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
