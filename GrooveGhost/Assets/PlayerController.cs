using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rbd;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        rbd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        HandleMovement();
    }

    void HandleMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rbd.velocity = new Vector2(rbd.velocity.x, speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            rbd.velocity = new Vector2(rbd.velocity.x, -speed);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            rbd.velocity = new Vector2(-speed, rbd.velocity.y);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            rbd.velocity = new Vector2(speed, rbd.velocity.y);
        }
        else
        {
            rbd.velocity = new Vector2(0, 0);

        }
    }
}
