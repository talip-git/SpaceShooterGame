using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public float rotaionSpeed = 100f;
    private float x_axis;
    private float y_axis;
    void FixedUpdate()
    {
        x_axis = Input.GetAxis("Horizontal");
        y_axis = Input.GetAxis("Vertical");
        transform.localRotation = Quaternion.Euler(new Vector3(y_axis * Time.deltaTime * rotaionSpeed, 0f, x_axis*Time.deltaTime*rotaionSpeed));
    }
}
