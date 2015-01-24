using UnityEngine;
using System.Collections;

public class Table : MonoBehaviour
{
	int sizeOnBillsSide = 5; // he has the negative side
	int sizeOnBobsSide = 5;

	int remotePosition = 0;

	public void MoveToBill(int dist)
	{
		remotePosition -= dist;

		if(sizeOnBillsSide < Mathf.Abs(remotePosition))
		{
			//TODO Game over
		}
	}

	public void MoveToBob(int dist)
	{
		remotePosition += dist;
		
		if(sizeOnBobsSide < Mathf.Abs(remotePosition))
		{
			//TODO Game over
		}
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
