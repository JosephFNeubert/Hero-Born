using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpBoostPickupBehavior : MonoBehaviour
{
    // Collision in trigger box
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Debug.Log("Jump Boost Effect");
            Destroy(this.transform.parent.gameObject);
        }
    }
}
