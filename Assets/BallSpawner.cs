using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

    public GameObject prefab;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        bool mouseDown = Input.GetMouseButtonDown(0);
        if (mouseDown)
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
