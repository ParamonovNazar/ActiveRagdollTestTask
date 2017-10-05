using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomForce : MonoBehaviour {
	[SerializeField]
	private Rigidbody rg;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.G)) {
			rg.AddForce (50,50 ,0,ForceMode.Impulse);
		}
		if (Input.GetKeyDown (KeyCode.F)) {
			rg.AddForce (-50,50 ,0,ForceMode.Impulse);
		}
	}


}
