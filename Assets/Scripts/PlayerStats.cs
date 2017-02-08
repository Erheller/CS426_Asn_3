using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextStuff : MonoBehaviour {
    public Text log0, log1, log2, log3, log4, log5, log6, log7;
    
	// Use this for initialization
	void Start () {
		
	}
	

    
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.Return)) {
            log0.text = " ";
            log1.text = " ";
            log2.text = " ";
            log3.text = " ";
            log4.text = " ";
            log5.text = " ";
            log6.text = " ";
        }
	}
}
