using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] float movement = 5f;


    void FixedUpdate()
    {
        if (Input.touchCount > 0 ) {

            foreach (Touch touch in Input.touches)
            {
                if(touch.position.y < Screen.height/2.5){

                    if(touch.position.x < Screen.width/2){
                        rb.MovePosition(rb.position - Vector2.right * movement *Time.deltaTime);
                    }
                    else if(touch.position.x > Screen.width/2){
                        rb.MovePosition(rb.position + Vector2.right * movement *Time.deltaTime);
                    }
                }

                else if (touch.position.y > Screen.height/4)
                {
                    Shoot.instanc.IsShooted = true ;
                }
            }
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.collider.tag == "ball")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
