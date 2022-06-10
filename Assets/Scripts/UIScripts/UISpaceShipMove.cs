using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UISpaceShipMove : MonoBehaviour
{
    public float speed;
    public float lerpDuration;
    private float elapsedTime;
    private float fraction;
    private Vector3 dest;
    private Vector3 start;
    private void Start()
    {
        dest = new Vector3(0f, 0f, 360);
        start = transform.rotation.eulerAngles;
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        StartCoroutine(rotation());
    }
    IEnumerator rotation()
    {
        yield return new WaitForSeconds(1);
        elapsedTime += Time.deltaTime;
        fraction = elapsedTime / lerpDuration;
        if(fraction <= 1)
        {
            transform.transform.eulerAngles = Vector3.Lerp(start,dest,fraction);
        }
    }
}
