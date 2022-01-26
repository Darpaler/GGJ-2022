using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterMoverTopDown))]
public class PlayerControllerTopDown : MonoBehaviour
{
    // Variables
    CharacterMoverTopDown characterMover;

    private Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        // Get components.
        characterMover = GetComponent<CharacterMoverTopDown>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        characterMover.Move(movement);
    }
}
