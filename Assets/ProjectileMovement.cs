using UnityEngine;
using System.Collections;

public class ProjectileMovement : MonoBehaviour {

    public float force = 5;
    bool hasAlreadyLaunched = false;

	// Use this for initialization
	void Start () {

	}

    void Update ()
    {

    }

    // Update is called once per frame
    void FixedUpdate() {
        if (!hasAlreadyLaunched)
        {
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.AddForce(transform.forward * force, ForceMode.Impulse);
            hasAlreadyLaunched = true;
        }
    }
}
