using UnityEngine;
using System.Collections;

public class CameraRay : MonoBehaviour {


	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        
    }

    public Ray GetAimRay()
    {
        Camera ourCamera = GetComponent<Camera>();
        Ray retVal = ourCamera.ScreenPointToRay(Input.mousePosition);
        return retVal;
    }
}
