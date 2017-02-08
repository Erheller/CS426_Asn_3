using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggController : MonoBehaviour {

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
		if(other.gameObject.CompareTag("Ground"))
		{
			Destroy (this.gameObject);
		}

        if (other.gameObject.CompareTag("avgjoe"))
        {
            Destroy(this.gameObject);
			GC.addScore (111);
        }

        if (other.gameObject.CompareTag("Egg"))
        {
            Physics.IgnoreCollision(this.GetComponent<Collider>(), other);
        }
	}
}

