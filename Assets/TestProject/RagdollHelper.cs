using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollHelper : MonoBehaviour {

	[SerializeField]private OnRagDoll ORD;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("asdasdasda");
	}
	 
}
