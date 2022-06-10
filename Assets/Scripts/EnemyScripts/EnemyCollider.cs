using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollider : MonoBehaviour
{
    public GameObject enemy;
    public GameObject explosion;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Lazer"))
        {
            Destroy(enemy);
            explosion.transform.position = transform.position;
            Instantiate(explosion);
        }
    }
}
