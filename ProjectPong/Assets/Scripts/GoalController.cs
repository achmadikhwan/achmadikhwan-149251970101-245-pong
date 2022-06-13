using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalController : MonoBehaviour
{   
    public Collider2D ball;
    public bool isLeft;
    public ScoreManager manager;
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision == ball)
        {
            if (isLeft)
            {
                manager.AddLeftScore(1);
            }
            else
            {
                manager.AddRightScore(1);
            }
        }
    }
}
