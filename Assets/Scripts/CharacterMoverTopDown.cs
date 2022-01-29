using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class CharacterMoverTopDown : MonoBehaviour
{

    // Variables
    
    
    // The character's movement speed.
    
    [Header("Movement Settings"), SerializeField]
    private float horizontalMoveSpeed = 5f;
    [SerializeField]
    private float verticalMoveSpeed = 5f;

    // The character's rigidbody2D component.
    private Rigidbody2D rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        // Get components.
        rigidbody2D = GetComponent<Rigidbody2D>();

    }

    public void Move(Vector2 movement)
    {
        movement.x *= horizontalMoveSpeed * Time.deltaTime;
        movement.y *= verticalMoveSpeed * Time.deltaTime;

        rigidbody2D.MovePosition(rigidbody2D.position + movement);
    }
}
