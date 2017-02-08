using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public float secondsPerDay;
	public int money;
	public int day;
	public bool shopping;

	private float secondsLeft;
	public PlayerController playerObject; 
	public Text UI_day;
	public Text UI_money;
	public Text UI_reg;
	public Text UI_org;
	public Text UI_ost;
	public Text UI_rot;


	// Use this for initialization
	void Start () {
		this.secondsPerDay = 90;
		this.money = 10000;
		this.day = 0;
		this.shopping = false;
		this.secondsLeft = this.secondsPerDay;

		DontDestroyOnLoad (this);




		this.updateUI ();

	}

	void updateUI() {
		UI_day.text = "Day: " + this.day.ToString ();
		UI_money.text = "ANARCHY POINTS: " + this.money.ToString ();
		UI_reg.text = "Regular Eggs: " + playerObject.getNumEggs (0).ToString ();
		UI_org.text = "Organic Eggs: " + playerObject.getNumEggs (1).ToString ();
		UI_ost.text = "Ostrich Eggs: " + playerObject.getNumEggs (2).ToString ();
		UI_rot.text = "Rotten Eggs: " + playerObject.getNumEggs (3).ToString ();

		int tempIndex = playerObject.getIndex ();
		UI_reg.color = Color.black;
		UI_org.color = Color.black;
		UI_ost.color = Color.black;
		UI_rot.color = Color.black;
		switch (tempIndex) {
		case 0:
			UI_reg.color = Color.blue;
			break;
		case 1:
			UI_org.color = Color.blue;
			break;
		case 2:
			UI_ost.color = Color.blue;
			break;
		case 3:
			UI_rot.color = Color.blue;
			break;
		}
	}
	
	// Update is called once per frame
	void Update () {
		this.updateUI ();



		//if time is less than zero, go shop
		if (this.secondsLeft <= 0) {
			this.shopping = true;
		}

		//not shopping, playing game
		if (this.shopping == false) {
			this.secondsLeft -= Time.deltaTime;

		}
	}


}
