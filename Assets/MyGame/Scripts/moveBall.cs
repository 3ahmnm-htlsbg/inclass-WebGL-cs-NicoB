using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBall : MonoBehaviour
{
	[SerializeField]  private GameObject[] ballPositions; 

	public GameObject BallGO;

	int randomInt;
	int randomIntBefore;

	void Start()
	{
		randomInt = 0;
		//if it would be null, it wouldnt be possible to start at position[0]
		randomIntBefore = 5;
	}
	public void GetRandomInt()
	{
		randomInt = Random.Range(0,4);
		if (randomInt != randomIntBefore)
		{
			randomIntBefore = randomInt;
			SetPosition();
		} else 
		{
			GetRandomInt();
		}
	}

	void SetPosition()
	{
		BallGO.transform.position = ballPositions[randomInt].transform.position;
	}
}