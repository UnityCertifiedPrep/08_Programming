using UnityEngine;
using System.Collections;

public class CameraAim : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Camera ourCamera = GetComponent<Camera>();
        Ray aimRay = ourCamera.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(aimRay.origin, aimRay.direction, Color.red);
    }
}
