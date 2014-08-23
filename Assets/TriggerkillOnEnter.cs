using UnityEngine;
using System.Collections;

public class TriggerkillOnEnter : MonoBehaviour {

	public void OnTriggerEnter2D(Collider2D other){
		Debug.Log (other.gameObject.name);
		Destroy (other.gameObject);
	}
}
