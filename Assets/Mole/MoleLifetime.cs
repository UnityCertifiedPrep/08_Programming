using UnityEngine;
using System.Collections;

public class MoleLifetime : MonoBehaviour
{
    public float duration = 5;
    float startTime;

    // Use this for initialization
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (startTime + duration < Time.time)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        print("Score!");
        Destroy(collision.collider.gameObject);
        Destroy(gameObject);
    }
}