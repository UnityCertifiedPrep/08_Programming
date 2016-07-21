using UnityEngine;
using System.Collections;

public class ConsolePrinter : MonoBehaviour {

    // Use this for initialization
    void Start() {
        Vector3 currentLocation = new Vector3(1.0f, 4.0f, 3.0f);
        Vector3 home = new Vector3(2.0f, 4.0f, 5.0f);
        Vector3 locationToHome = currentLocation - home;
        print("Distance to home " + locationToHome.magnitude);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
