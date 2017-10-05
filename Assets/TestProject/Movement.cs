using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
	
	public float ForceSpeed{  get; private set;}
	public bool IsMoving{  get; private set;} 
	public bool IsFasingRight {  get; private set;} 
 
	public float HorizontalSpeed{  get; private set;}
	[SerializeField] 
	private Rigidbody Rb; 
	[SerializeField] 
	private float MaxSpeed=5f;
	void Start () {
		IsMoving =false;
		IsFasingRight=false;
		ForceSpeed = 100f;
	}

	void FixedUpdate () {
		if (Input.GetKey (KeyCode.A)) {
			Move(false);
		}

		if (Input.GetKey (KeyCode.D)) {
			Move(true);
		}
		HorizontalSpeed = Rb.velocity.x;
	}

	void Move(bool direct){
		float dir = 1;
		if (!IsFasingRight) {
			dir = -1;
		}
		if (IsFasingRight != direct) {
			Flip ();
		}

		Vector3 forceDirection = new Vector3 (dir,0,0);
		Debug.Log (forceDirection);
		Rb.AddForce (forceDirection*ForceSpeed,ForceMode.Force);
		if (Mathf.Abs (Rb.velocity.x) > MaxSpeed) {
			Vector3 MaxVelocity = new Vector3 (MaxSpeed,Rb.velocity.y,Rb.velocity.z);
			Rb.velocity = MaxVelocity*dir;
		}

	}
	void Flip(){
		if (IsFasingRight) {
			Vector3 NewScale = Vector3.one;
			NewScale.x = 1f;
			transform.localScale = NewScale;
			IsFasingRight = false;
		} else {
			Vector3 NewScale = Vector3.one;
			NewScale.x = -1f;
			transform.localScale = NewScale;
			IsFasingRight = true;
		}

	}
}
