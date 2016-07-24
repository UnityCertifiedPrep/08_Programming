using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

    public GameObject prefab;
    public CameraAim aimComponent;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        bool mouseDown = Input.GetMouseButtonDown(0);
        if (mouseDown)
        {
            Ray aimRay = aimComponent.GetAimRay();
            Quaternion aimRotation = Quaternion.LookRotation(aimRay.direction);
            Instantiate(prefab, transform.position, aimRotation);
        }
    }
}
