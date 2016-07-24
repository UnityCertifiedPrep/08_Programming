using UnityEngine;
using System.Collections;

public class CameraAim : MonoBehaviour {

    public Ray GetAimRay()
    {
        Camera ourCamera = GetComponent<Camera>();
        Ray aimRay = ourCamera.ScreenPointToRay(Input.mousePosition);
        Debug.DrawRay(aimRay.origin, aimRay.direction, Color.red);
        return aimRay;
    }
}
