using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Table : MonoBehaviour
{
	int sizeOnBillsSide = 5; // he has the negative side
	int sizeOnBobsSide = 5;

	public GameObject remote;
	int remotePosition = 5;
	float widthOfPiece = 0.09f;

	public GameObject[] pieces;
	int leftCutIndex = 10;
	int rightCutIndex = 0;

	public void MoveToBill(int dist)
	{
		remotePosition += dist;
		remote.transform.localPosition -= new Vector3(widthOfPiece,0,0);

		if(leftCutIndex < remotePosition)
		{
			//TODO Game over
			Debug.Log ("Game over");
		}
	}

	public void MoveToBob(int dist)
	{
		remotePosition -= dist;
		remote.transform.localPosition += new Vector3(widthOfPiece,0,0);
		
		if(rightCutIndex > remotePosition)
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
			pieces[leftCutIndex].SetActive(false);
			leftCutIndex--;
		}
		else
		{
			sizeOnBobsSide--;
			pieces[rightCutIndex].SetActive(false);
			rightCutIndex++;
		}
		if(leftCutIndex < remotePosition || rightCutIndex > remotePosition)
		{
			//TODO Game over
			Debug.Log ("Game over");
		}

	}

	public void TapeMeUp(bool BillsSide)
	{
		if(BillsSide)
		{
			if(sizeOnBobsSide < 5)
			{
				sizeOnBobsSide++;
				pieces[--rightCutIndex].SetActive(true);
			}
		}
		else
		{
			if(sizeOnBillsSide < 5)
			{
				sizeOnBillsSide++;
				pieces[++leftCutIndex].SetActive(true);
			}
		}		
	}

	void Start()
	{
//		remote.transform.localPosition += new Vector3(widthOfPiece*5,0,0);
	}
	
}
