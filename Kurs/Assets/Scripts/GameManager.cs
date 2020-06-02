using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager current;
								
	float totalGameTime;						
	bool isGameOver;	
	public static bool IsFirstCorrect = false;

    void Awake()
	{
		if (current != null && current != this)
		{
			Destroy(gameObject);
			return;
		}
		current = this;
		DontDestroyOnLoad(gameObject);
	}

	

	void Update()
	{
		if (isGameOver)
			return;
		totalGameTime += Time.deltaTime;
	}

	public static bool IsGameOver()
	{
		if (current == null)
			return false;
		return current.isGameOver;
	}


	public static void PlayerWon()
	{
		if (current == null)
			return;

		current.isGameOver = true;

		//AudioManager.PlayWonAudio();
	}

}
