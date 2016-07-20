using UnityEngine;
using System.Collections;

public class ConsoleWelcomer : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int anInteger = 1000;
        float aFloat = 2.5f;
        float sum = anInteger + aFloat;
        float average = sum / 2;
        print("anInteger = " + anInteger);
        print("aFloat = " + aFloat);
        print("sum = " + sum);
        print("average = " + average);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
