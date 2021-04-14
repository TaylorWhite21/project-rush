using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeep : MonoBehaviour
{
    int hits = 0;
    float collectedCoins = 0;


    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Coin")
        {
            collectedCoins++;
            Destroy(other.gameObject);
            Debug.Log(collectedCoins + " coin(s) collected");
            return;
        }

        if (other.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("You've bumped into something this amny times:" + hits);
        }
    }
}
