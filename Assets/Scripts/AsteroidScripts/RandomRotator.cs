using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class RandomRotator : MonoBehaviour
{
    [SerializeField]
    private float tumble;
    public GameObject expolsion;

    private float[] speeds = {2f,3f,7f};
    private int[] directions = {1,2,3};
    private int direction;
    void Start()
    {
        direction = Mathf.RoundToInt(Random.Range(0, 3));
        GetComponent<Rigidbody>().angularVelocity = Random.insideUnitSphere ;
        GetComponent<Rigidbody>().angularDrag = Time.deltaTime ;
    }
    private void Update()
    {
        if(direction == 1)
        {
            transform.Translate(Vector3.right * speeds[direction] * Time.deltaTime);

        }
        else if(direction == 2)
        {
            transform.Translate(Vector3.up * speeds[direction] * Time.deltaTime);
        }
        else if(direction == 3)
        {
            transform.Translate(Vector3.forward * speeds[direction] * Time.deltaTime);
        }
        else
        {
            Debug.Log(direction);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Lazer"))
        {
            //Destroy both meteor and lazer
            Destroy(gameObject);
            Destroy(other.gameObject);

            //Instantiate explosion in the exact location of the meteor
            InstantiateExplosion();
            ScoreController.currentScore += 5;
            //Destroy the explosion
            StartCoroutine(destroyExplosion(expolsion));
        }
    }
    void InstantiateExplosion()
    {
        expolsion.transform.position = this.transform.position;
        GameObject ex = Instantiate(expolsion);
        StartCoroutine(destroyExplosion(expolsion));
    }
    IEnumerator destroyExplosion(GameObject exp)
    {
        yield return new WaitForSeconds(2);
        Debug.Log("Inside coroutine!");
        Destroy(expolsion);
    }
}