using UnityEngine;
using System.Collections;

public class RockSpawner : MonoBehaviour {
	public float maxGap = 4f;
	public float minGap = 2f;

	public float spawnDelay = 0.5f;

	public GameObject upRock;
	public GameObject downRock;

	private float nextSpawnTime = 0.0f;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (nextSpawnTime <= Time.time){
			//SPAWN
			float gap = Random.Range(minGap,maxGap);
			float offset = Random.Range(0f,1f);

			Vector3 upPos = transform.position;
			Vector3 downPos = transform.position;


			upPos.y = -1.75f - gap*offset; //randomize a number 0-1 and multiply instead of deviding by 2.
			downPos.y = 1.75f + gap*(1-offset);
			Instantiate(upRock,upPos,Quaternion.identity);
			Instantiate(downRock,downPos,Quaternion.identity);

			nextSpawnTime =Time.time+ spawnDelay;
		}

	}
}
