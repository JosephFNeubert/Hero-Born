using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapBehavior : MonoBehaviour
{
    public GameBehavior gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameBehavior>();
    }

    // Called upon collision
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Player") {
            gameManager.HP = 0;
        }
    }
}
