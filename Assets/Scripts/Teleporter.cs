using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Teleporter : MonoBehaviour
{
    // Variables

    // Transform of where to teleport to.
    [SerializeField]
    Teleporter teleportTo;
    
    // Time in between teleports.
    [SerializeField]
    float coolDownTime = 1f;

    // Time when the teleporter will be ready again.
    float nextTeleportTime = 0f;

    // If the teleporter is ready to teleport.
    bool isReady = true;

    // If there is an object blocking the teleporter.
    bool isBlocked = false;
    

    private void Update()
    {
        if (!isReady && Time.time > nextTeleportTime)
        {
            Debug.Log(gameObject.name + " is now ready again.");
            isReady = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (isReady && !teleportTo.isBlocked)
        {
            teleportTo.nextTeleportTime = Time.time + coolDownTime;
            teleportTo.isReady= false;
            collision.gameObject.transform.position = teleportTo.transform.position;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        isBlocked = true;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        isBlocked = false;
    }
}
