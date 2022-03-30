using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] float speed = 5f;

    Rigidbody2D rigidBody2D;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
        SetRandomVelocity();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Reset();
        }
    }

    private void SetRandomVelocity()
    {
        if(Random.value<0.5f)
        {
            //Move ball right
            rigidBody2D.velocity = new Vector2(1,0) * speed;

        }
        else
        {
            //Move ball left
            rigidBody2D.velocity = new Vector2(-1,0) * speed;
        }
    }

    public void Reset()
    {
        //Stop 
        rigidBody2D.velocity = new Vector2(0,0);
        //Reposition
        rigidBody2D.position = new Vector2(0,0);
        //Set Random Direction
        SetRandomVelocity();
    }
    /// <summary>
    /// sent when an incoming collider makes contact with this object's collider(2D physics only).
    /// </summary>
    /// <param name="other">The Collision2D data associated with this collision.</param>

    void OnCollisionEnter2D(Collision2D other)
    {
        float collisionPoint = (transform.position.y - other.transform.position.y) / other.collider.bounds.size.y;

        if(other.gameObject.tag == "RightPaddle")
        {
            rigidBody2D.velocity = new Vector2(-1, collisionPoint).normalized * speed;
        }
        else if(other.gameObject.tag == "LeftPaddle")
        {
            rigidBody2D.velocity = new Vector2(1, collisionPoint).normalized * speed;
        }
    }
}
