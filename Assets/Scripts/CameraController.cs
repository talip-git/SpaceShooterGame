using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Vector3 back = Vector3.up * 180f;

    private float lookBack = 0;
    private float smooth = 1;
    void Update()
    {
        LookBack();
        ZoomOut();
    }
    void LookBack()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            lookBack = 1;
            transform.localRotation = Quaternion.Euler(back * lookBack);
        }
        else
        {
            lookBack = 0;
            transform.localRotation = Quaternion.Euler(back * lookBack);
        }
    }
     void ZoomOut()
    {
        if (Input.GetKey(KeyCode.T))
        {
            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, 100, Time.deltaTime * smooth);
        }
        else
        {
            GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, 60, Time.deltaTime * smooth);
        }

    }
}
