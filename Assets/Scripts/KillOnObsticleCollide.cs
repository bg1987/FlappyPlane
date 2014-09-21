using UnityEngine;
using System.Collections;

public class KillOnObsticleCollide : MonoBehaviour {

    public GameObject gameoverText;
    public RockSpawner rocks;

    private bool dead = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "Obsticle") {
            gameoverText.SetActive(true);
            ConstantSpeed.speed = 0f;
            rocks.go = false;
		}

        if (dead && Input.GetButton("Jump") || Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Application.LoadLevel(0);
        }
	}

}
