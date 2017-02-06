using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggController : MonoBehaviour {

	private Rigidbody rb;
	// Use this for initialization
	void Start () {
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

        if (other.gameObject.CompareTag("Joe"))
        {
            Destroy(this.gameObject);
        }

        if (other.gameObject.CompareTag("Egg"))
        {
            Physics.IgnoreCollision(this.GetComponent<Collider>(), other);
        }
	}
}

