using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootStop : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        Shoot.instanc.IsShooted = false;

        if(other.tag == "ball")
        {
            other.GetComponent<Ball>().split();

        }
    }

}
