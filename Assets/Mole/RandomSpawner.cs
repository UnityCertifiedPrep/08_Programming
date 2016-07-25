using UnityEngine;
using System.Collections;

public class RandomSpawner : MonoBehaviour {

    public float interval = 5;
    public GameObject prefab;
    public float spawnRadius = 5;
    float lastSpawnTime = 0;
    

	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    if (lastSpawnTime + interval < Time.time)
        {
            var randomOffset = Random.insideUnitSphere * spawnRadius;
            Instantiate(prefab, transform.position + randomOffset, transform.rotation);
            lastSpawnTime = Time.time;
        }
	}
}
