using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour
{
	public Canvas gameUI;
	public Canvas endUI;

	public Text finalScore;
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			Time.timeScale = 0;
			GameManager.instance.score *= PlayerController.instance.health;
			finalScore.text = "Score: " + GameManager.instance.score;
			gameUI.enabled = false;
			endUI.enabled = true;
		}
	}
}
