﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggRottenController : MonoBehaviour {

	private Rigidbody rb;
	public GameObject GO;
	public GameController GC;

	// Use this for initialization
	void Start () {
		//GC = GameObject.FindGameObjectWithTag ("GameController");

		GO = GameObject.FindGameObjectWithTag ("GameController");
		GC = GO.GetComponent<GameController> ();

		rb = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Egg"))
		{
			Physics.IgnoreCollision(this.GetComponent<Collider>(), other);
			return;
		}

		GameObject.Instantiate((GameObject)Resources.Load("p_rotten_exp"), this.transform.position, this.transform.rotation);

		Destroy (this.gameObject);







		if(other.gameObject.CompareTag("Ground"))
		{
			Destroy (this.gameObject);
			return;
		}

		if (other.gameObject.CompareTag("avgjoe"))
		{
			if (this.gameObject.CompareTag ("orgo"))
				GC.addScore (50);
			else
				GC.addScore (10);
			Destroy(this.gameObject);
			return;
		}

		if (other.gameObject.CompareTag("hipjoe"))
		{
			Destroy(this.gameObject);
			GC.addScore (10);
			return;
		}

		if (other.gameObject.CompareTag("skatejoe"))
		{
			Destroy(this.gameObject);
			GC.addScore (30);
			return;
		}


	}
}

