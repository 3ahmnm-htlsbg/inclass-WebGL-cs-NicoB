using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class moveBall : MonoBehaviour
{
	[SerializeField] private GameObject[] ballPositions; 

	[SerializeField] private GameObject BallGO;

	[SerializeField] private Slider sliderGO;

	int randomInt = 0;
	//if it would be null, it wouldnt be possible to start at position[0]
	int randomIntBefore = 5;

	bool doubleIntEnabled = false;

	public void GetRandomInt()
	{
		randomInt = Random.Range(0,4);
		if (doubleIntEnabled == false) 
		{
			if (randomInt != randomIntBefore)
			{
				randomIntBefore = randomInt;
				SetPosition();
			} else 
			{
			GetRandomInt();
			}
		} else
		{
			SetPosition();
		}
	}

	void SetPosition()
	{
		BallGO.transform.position = ballPositions[randomInt].transform.position;
	}

	public void EnableDouble() 
	{
		doubleIntEnabled = true;
	}
	public void DisableDouble()
	{
		doubleIntEnabled = false;
	}
	public void GetScale()
	{
		float scaleX = sliderGO.value * 20f;
		float scaleY = sliderGO.value * 20f;

		BallGO.transform.localScale = new Vector3 (scaleX, scaleY, 1);
	}
}