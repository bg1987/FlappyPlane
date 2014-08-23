using UnityEngine;
using System.Collections;

public class ConstantSpeed : MonoBehaviour {
	static public float speed = 0.1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += Vector3.left * speed;
	}
}
