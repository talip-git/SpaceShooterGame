using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public GameObject lazer;
    public float[] lazerDurations = { 1f, 2f,3f, 4.1f };
    void Start()
    {
        StartCoroutine(shootLazer());
    }
    IEnumerator shootLazer()
    {
        while (true)
        {
            yield return new WaitForSeconds(lazerDurations[Mathf.RoundToInt(Random.Range(0,lazerDurations.Length))]);
            lazer.transform.position = this.transform.position;
            lazer.transform.rotation = this.transform.rotation;
            Instantiate(lazer);
        }
    }
}
