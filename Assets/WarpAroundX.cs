using UnityEngine;
using System.Collections;

public class WarpAroundX : MonoBehaviour {
	public float startX;
	public float edgeX;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < edgeX) {
			transform.position = new Vector3(startX,transform.position.y,transform.position.z);
				}
	}
}
