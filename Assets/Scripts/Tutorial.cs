using UnityEngine;
using System.Collections;

public class Tutorial : MonoBehaviour {
    public GameObject player;
    public RockSpawner rock;

    private float gravity;
	// Use this for initialization
	void Start () {

        player.GetComponent<JumpPlane>().enabled = false;
        gravity = player.GetComponent<Rigidbody2D>().gravityScale;
        player.GetComponent<Rigidbody2D>().gravityScale = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Jump") || Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            rock.go = true;
            player.GetComponent<JumpPlane>().enabled = true;
            player.GetComponent<Rigidbody2D>().gravityScale = gravity;
            Destroy(gameObject);
        }
        
	}
}
