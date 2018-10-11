﻿using UnityEngine;
using System.Collections;

public class RedVirus : MonoBehaviour {

	public int pointsToAdd;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTriggerStay2D(Collider2D other)
	{
		if(other.gameObject.tag == "VirusDestroyer")
		{
			if(Input.GetKeyDown(KeyCode.A))
			{
				GameManager.Instance.AddPoints(pointsToAdd);
				Destroy(gameObject); 
			}
			else if(Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.S))
			{
				GameManager.Instance.AddPoints(-10);
				//Destroy(gameObject);
			}
		}
	}
}
