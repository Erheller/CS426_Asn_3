using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopRotating : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, lockPos, lockPos);
		transform.rotation = Quaternion.Euler(-90, transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.x);
	}
}
