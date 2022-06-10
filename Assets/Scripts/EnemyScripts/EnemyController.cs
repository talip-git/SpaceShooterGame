using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed;
    public GameObject player;
    public float radius;
    public float rotationTreshold;

    public float lerpSpeed;

    public float move2Speed;

    public Vector3 enemyOffset;
    private Vector3 random;
    private float startTime = 0;
    private float journeyLength;
    void Start()
    {
        random = new Vector3(Random.Range(-enemyOffset.x, enemyOffset.x),
            Random.Range(-enemyOffset.y, enemyOffset.y), Random.Range(enemyOffset.z, enemyOffset.z + 50));
        StartCoroutine(changeVector());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        focusPlayer();
        moveEnemy2();
    }
    void moveEnemy2()
    {
        Vector3 start = this.transform.position;
        Vector3 dest = player.transform.position;
        float distance = Vector3.Distance(start, dest + random);
        Debug.Log(distance);
        if (inRange() && distance>60) 
        {
            transform.position = Vector3.Lerp(start, dest + random, move2Speed * Time.deltaTime);
        }
    }
    void moveEnemy()
    {
        if (inRange())
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }
    void focusPlayer()
    {
        Vector3 enemytoPlayer = player.transform.position - this.transform.position;
        Quaternion rotation = Quaternion.LookRotation(enemytoPlayer);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, lerpSpeed * Time.deltaTime);
    }
    bool inRange()
    {
        Vector3 playerLocation = player.transform.position;
        float distance = Vector3.Distance(transform.position, playerLocation);
        if (distance > radius)
        {
            return true;
        }
        return false;
    }
    IEnumerator changeVector()
    {
        while (true)
        {
            yield return new WaitForSeconds(4f);
            random = new Vector3(Random.Range(-enemyOffset.x, enemyOffset.x),
                Random.Range(-enemyOffset.y, enemyOffset.y), Random.Range(-enemyOffset.z, enemyOffset.z + 100));
        }
    } 
}
