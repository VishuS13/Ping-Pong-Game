using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSession : MonoBehaviour
{
    [SerializeField] Text RightScore;
    [SerializeField] Text LeftScore;

    private int leftScore;
    private int rightScore;


    // Start is called before the first frame update
    void Start()
    {

    }

    public void Reset()
    {
        leftScore = 0;
        rightScore = 0;

    }
    // Update is called once per frame
    void Update()
    {
        RightScore.text = rightScore.ToString();
        LeftScore.text = leftScore.ToString();

    }

    public void IncreaseScore(int player)
    {
        switch (player)
        {
            case 1:
                rightScore++;
                break;
            case 2:
                leftScore++;
                break;

        }


    }
}
