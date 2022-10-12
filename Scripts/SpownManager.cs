using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpownManager : MonoBehaviour
{
    [SerializeField] GameObject[] Ball;


    void Start()
    {
        Invoke("LaunchProjectile4", 2f);
    }

    void LaunchProjectile()
    {
        Instantiate(Ball[0], transform.position ,Quaternion.identity);
        Invoke("LaunchProjectile", 60f);
    }
    void LaunchProjectile1()
    {
        Instantiate(Ball[1], transform.position ,Quaternion.identity);
        Invoke("LaunchProjectile", 20f);
    }

    void LaunchProjectile2()
    {
        Instantiate(Ball[2], transform.position ,Quaternion.identity);
        Invoke("LaunchProjectile1", 15f);
    }
    void LaunchProjectile3()
    {
        Instantiate(Ball[3], transform.position ,Quaternion.identity);
        Invoke("LaunchProjectile2", 10f);
    }

    void LaunchProjectile4()
    {
        Instantiate(Ball[4], transform.position ,Quaternion.identity);
        Invoke("LaunchProjectile3", 4f);
    }  
}
