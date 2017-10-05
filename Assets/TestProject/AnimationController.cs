using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour {
	[SerializeField]
	private Movement movement;
	[SerializeField]
	private Animator anim; 
	[SerializeField]
	public float RunSpeed=5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		anim.SetFloat ("Speed",Mathf.Abs(movement.HorizontalSpeed));
		anim.SetFloat ("RunMultiplier",Mathf.Abs(movement.HorizontalSpeed)/RunSpeed);
	}
}
