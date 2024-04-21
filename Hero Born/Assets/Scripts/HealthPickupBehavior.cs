using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickupBehavior : MonoBehaviour
{
    public GameBehavior gameManager;

    // Run on first frame
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameBehavior>();
    }

    // Collision in trigger box
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Player")
        {
            Debug.Log("+1 Health");
            gameManager.HP += 1;
            Destroy(this.gameObject);
        }
    }
}
