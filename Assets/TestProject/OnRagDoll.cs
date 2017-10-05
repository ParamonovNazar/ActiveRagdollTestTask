using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnRagDoll : MonoBehaviour {
	private bool fl=true;
	public Animator anim;
	public GameObject [] ik;
	public Rigidbody [] allRigid;
	public Collider c;
	// Use this for initialization
	void Start () {
		RagDollOn ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			RagDollOn ();
		}
	}
	public void RagDollOn(){
		Debug.Log (GetComponentsInChildren<Rigidbody>().Length);
		foreach ( Rigidbody rb in GetComponentsInChildren<Rigidbody>() ) {
			rb.isKinematic = fl;
		}
		anim.enabled = fl;
		c.enabled = fl;
		foreach (GameObject g in ik) {
			g.SetActive (fl);
		}
		fl = !fl;
	}
}
