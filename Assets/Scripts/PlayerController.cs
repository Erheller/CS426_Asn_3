using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public int speed = 5;
	private string[] eggArray;
	private int numEggs = 4;
	private int index;


	// Use this for initialization
	void Start () {
		eggArray = new string[numEggs];

		eggArray [0] = "p_egg";
		eggArray [1] = "p_egg_organic";
		eggArray [2] = "p_egg_ostrich";
		eggArray [3] = "p_egg_rotten";

		this.index = 0;
	}
	
	// Update is called once per frame
	void Update () {

		int direction = 0;

		if (Input.GetKey(KeyCode.R)) {
			Application.LoadLevel(Application.loadedLevel);
		}



		if (Input.GetKey (KeyCode.RightArrow)) {
			direction++;
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			direction--;
		}

		if (direction != 0) {
			if (direction == 1) {
				transform.Translate (this.transform.forward * Time.deltaTime);
			} 

			else {
				transform.Translate (this.transform.forward * -1 * Time.deltaTime);
			}
		}

		if (Input.GetKey (KeyCode.UpArrow)) {
			if (this.index == this.numEggs - 1)
				this.index = 0;
			else
				this.index++;

		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			if (this.index == 0)
				this.index = this.numEggs - 1;
			else
				this.index--;
		}



		if (Input.GetKeyDown (KeyCode.Space)) {
			//egg creation here
			Vector3 player_front = new Vector3(this.transform.position.x + 3, this.transform.position.y, this.transform.position.z);


			GameObject.Instantiate((GameObject)Resources.Load(this.eggArray[this.index]), /*this.transform.position*/player_front, this.transform.rotation);
		}

	}
}
