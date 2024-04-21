using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBoxScript : MonoBehaviour
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
        if (other.name == "Player")
        {
            Debug.Log("+10 Ammo");
            gameManager.Ammo += 10;
            Destroy(this.gameObject);
        }
    }
}
