using UnityEngine;
using System.Collections;

public class Babo : MonoBehaviour
{
	public Player Bill;
	public Player Bob;
	Player activePlayer;



	// Use this for initialization
	void Start ()
	{
		//TODO make starting player random
		activePlayer = Bill;

		Bill.GetReady();
		Bob.GetReady();
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
