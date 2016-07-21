using UnityEngine;
using System.Collections;

public class MovementTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        ProjectileMovement projectileMovementObject = GetComponent<ProjectileMovement>();
        projectileMovementObject.UpdatePosition();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
