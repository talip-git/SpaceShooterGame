using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float speed = 50f;
    public float rotaionTreshold = 100f;
    private float x_axis;
    private float y_axis;
    private float tmpSpeed;
    [SerializeField]
    private float speedUpTime;
    private float waitSeconds;
    private float elapsedTime;
    public float boostTimer=5f;

    private void Start()
    {
        tmpSpeed = speed;
    }
    void Update()
    {
        fixedSpeedMove();
        horizontalRotataion();
        verticalRotation();
        speedUp2();
    }
    void fixedSpeedMove()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
    void horizontalRotataion()
    {
        x_axis = Input.GetAxis("Horizontal");
        if (!(x_axis == 0))
        {
            transform.Rotate(0f, 0f, x_axis * rotaionTreshold * Time.deltaTime);
        }
    }
    void verticalRotation()
    {
        y_axis = Input.GetAxis("Vertical");
        if(!(y_axis == 0))
        {
            transform.Rotate(y_axis * rotaionTreshold * Time.deltaTime,0f,0f);
        }
    }
    void speedUp()
    {
        if(elapsedTime <= waitSeconds)
        {
            elapsedTime += Time.deltaTime;
        }
        if(elapsedTime == waitSeconds)
        {
            speed = speed * 2;
            speedUpTime += Time.deltaTime;
            if(speedUpTime == elapsedTime)
            {
                elapsedTime = 0;
                speedUpTime = 0;
            }
        }
    }

    void speedUp2(){
        if(Input.GetKey(KeyCode.T)) {
            if(boostTimer>=0){
                boostTimer-= Time.deltaTime;
                speed = 2 * tmpSpeed;
            }
        }
        else {
            if(boostTimer<5){
                boostTimer+=Time.deltaTime;
                speed = tmpSpeed;
            }
        }
    }
}
