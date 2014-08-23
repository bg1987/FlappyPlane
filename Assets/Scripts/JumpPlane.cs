using UnityEngine;
using System.Collections;

public class JumpPlane : MonoBehaviour {

	public float jumpForce = 100f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetButton("Jump") )
	    {
			rigidbody2D.velocity = Vector2.zero;
			rigidbody2D.AddForce(Vector2.up*jumpForce);
		}
	}
}
