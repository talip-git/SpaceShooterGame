using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerFire : MonoBehaviour
{
    public GameObject lazer;
    void Update()
    {
        shoot();
    }
    void shoot()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            lazer.transform.position = this.transform.position;
            lazer.transform.rotation = this.transform.rotation;
            Instantiate(lazer);
        }
    }
}
