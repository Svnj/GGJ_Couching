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
			Debug.Log ("Game over");
		}
	}

	public void MoveToBob(int dist)
	{
		remotePosition += dist;
		
		if(sizeOnBobsSide < Mathf.Abs(remotePosition))
		{
			//TODO Game over
			Debug.Log ("Game over");
		}
	}

	public void CutMeDown(bool BillsSide)
	{
		if(BillsSide)
		{
			sizeOnBillsSide--;
		}
		else
		{
			sizeOnBobsSide--;
		}
		if(sizeOnBillsSide < Mathf.Abs(remotePosition) || sizeOnBobsSide < Mathf.Abs(remotePosition))
		{
			//TODO Game over
			Debug.Log ("Game over");
		}

	}

	public void TapeMeUp(bool BillsSide)
	{
		if(BillsSide)
		{
			sizeOnBillsSide++;
		}
		else
		{
			sizeOnBobsSide++;
		}		
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
