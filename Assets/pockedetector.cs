using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class pockedetector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ball"))
        {
            GameManager gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            Destroy(other.gameObject);

            // Add the score to the player's score
            gameManager.AddScore(1);
        }
    }
}
