using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public static GameManager instance;

	public int score;

	public Text healthTxt;
	public Text scoreTxt;
	private void Awake()
	{
		if (!instance)
		{
			instance = this;
		}
	}
	public void Update()
	{
		healthTxt.text = PlayerController.instance.health.ToString();
		scoreTxt.text = score.ToString();
	}
	public void GameReset()
	{
		Scene scene = SceneManager.GetActiveScene();
		SceneManager.LoadScene(scene.name);
	}

	public void ChangeScore(int fruitValue)
	{
		score += fruitValue;
	}
}
