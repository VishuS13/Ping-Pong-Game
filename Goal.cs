using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    [SerializeField] GameSession gameSession;
  
    private Ball ball;  

    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<Ball>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(tag == "LeftGoal")
        {
            //increase rightPaddle score
            gameSession.IncreaseScore(1);
            ball.Reset();
        }

        else if(tag == "RightGoal")
        {
            //increase leftPaddle score
            gameSession.IncreaseScore(2);
            ball.Reset();
        }
    }
 }
