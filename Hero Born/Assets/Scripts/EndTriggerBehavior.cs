using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTriggerBehavior : MonoBehaviour
{
    public GameBehavior gameManager;

    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameBehavior>();    
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            gameManager.win();
        }
    }
}
