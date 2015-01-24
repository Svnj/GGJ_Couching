using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Player : MonoBehaviour {

	int numOfTurnsLeft;

	IList<CardSoul> cards;

	public CardPool couch;
 
	public void GetReady()
	{
		for(int i = 0; i<3; i++)
		{
			cards.Add(couch.GetCard());
		}
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
