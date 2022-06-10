using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameZoneController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Lazer"))
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.CompareTag("EnemyLazer"))
        {
            Destroy(other.gameObject);
        }
    }
}
