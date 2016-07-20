using UnityEngine;
using System.Collections;

public class ForceCalculator : MonoBehaviour {

    public float accelerationDueToGravity = 9.81f;

    // Use this for initialization
    void Start () {
        print("Acceleration due to graity: " + accelerationDueToGravity);
        print("Force on 10kg mass = " + ForceDueToGravity(10));
    }

    float ForceDueToGravity (float mass)
    {
        return mass * accelerationDueToGravity;
    }

    float Square (float x)
    {
        return x * x;
    }


	
	// Update is called once per frame
	void Update () {
	
	}
}
