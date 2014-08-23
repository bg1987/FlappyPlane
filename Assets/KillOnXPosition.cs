using UnityEngine;
using System.Collections;

public class KillOnXPosition : MonoBehaviour {
	public float xEdge = -10f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < xEdge) {
			Destroy(this.gameObject);
				}
	}
}
