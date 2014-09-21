using UnityEngine;
using System.Collections;

public class ScoreTrigger : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        GameObject.Find("ScoreKeeper").SendMessage("ScoreUp");
    }


}
