using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerMovement : MonoBehaviour
{
    [SerializeField]
    private float lazerSpeed = 1000f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0f, 0f, lazerSpeed * Time.deltaTime));
    }
}
