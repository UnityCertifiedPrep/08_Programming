using UnityEngine;
using System.Collections;

public class ProjectileMovement : MonoBehaviour {

    public Vector3 newPosition;

	// Use this for initialization
	void Start () {

	}

    public void UpdatePosition()
    {
        Transform trans = GetComponent<Transform>();
        trans.position = newPosition;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
