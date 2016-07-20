using UnityEngine;
using System.Collections;

public class AverageCalculator : MonoBehaviour {

    public float inputOne;
    public float inputTwo;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        print("Average = " + Average(inputOne, inputTwo));
    }

    float Average(float a, float b)
    {
        float sum = a + b;
        return sum / 2;
    }
}
