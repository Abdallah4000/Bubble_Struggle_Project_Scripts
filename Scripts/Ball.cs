using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    [SerializeField] Vector2 startForce;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] GameObject NextBall;
    void Start()
    {
        rb.AddForce(startForce,ForceMode2D.Impulse);
    }

    public void split()
    {
        Shoot.instanc.ScoreAdd();
        if(NextBall != null)
        {
            GameObject ball1 =  Instantiate(NextBall, rb.position + Vector2.right/4 , Quaternion.identity);
            GameObject ball2 = Instantiate(NextBall, rb.position + Vector2.left/4 , Quaternion.identity); 

            ball1.GetComponent<Ball>().startForce = new Vector2(4f,4f);
            ball2.GetComponent<Ball>().startForce = new Vector2(-4f,4f);
        }
        Destroy(gameObject);
    }

}
