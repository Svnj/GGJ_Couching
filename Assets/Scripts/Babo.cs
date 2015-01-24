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
	}

	public void CutTable()
	{
		table.CutMeDown(activePlayer == Bill);
	}

	public void TapeTable()
	{
		table.TapeMeUp(activePlayer == Bill);
	}

	public void MoveRemoteToBill(int dist)
	{
		table.MoveToBill(dist);
	}

	public void MoveRemoteToBob(int dist)
	{
		table.MoveToBob(dist);
	}

	public void PauseForBill(int turns)
	{
		Bill.numOfTurnsLeft = 0;
		Bob.numOfTurnsLeft =turns;
	}

	public void PauseForBob(int turns)
	{
		Bob.numOfTurnsLeft = 0;
		Bill.numOfTurnsLeft =turns;
	}

	public void GiveCard(int count)
	{
		if (activePlayer == Bill)
		{

		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
