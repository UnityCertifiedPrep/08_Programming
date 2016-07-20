using UnityEngine;
using System.Collections;

public class ConsoleWelcomer : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int anInteger = 1000;
        float aFloat = 2.5f;
        float aSecondFloat = 10.0f;
        print("anInteger = " + anInteger);
        print("aFloat = " + aFloat);
        print("average = " + Average(aFloat, aSecondFloat));
        print("square aFloat = " + Square(Square(aFloat)));
	}

    float Square (float x)
    {
        return x * x;
    }

    float Average (float a, float b)
    {
        float sum = a + b;
        return sum / 2;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
