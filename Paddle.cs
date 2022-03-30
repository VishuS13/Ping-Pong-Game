using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float speed = 6f;

    Rigidbody2D rigidBody2D;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (tag == "RightPaddle")
        {

            rigidBody2D.velocity = new Vector2(0, Input.GetAxis("Vertical") * speed);
        }   
        else if(tag == "LeftPaddle")
        {
            rigidBody2D.velocity = new Vector2(0, Input.GetAxis("Vertical2") * speed);
        }
    }
}
