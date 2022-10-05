using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit : MonoBehaviour
{
	public int value = 500;
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			GameManager.instance.ChangeScore(value);
			Destroy(gameObject);
		}
	}
}
