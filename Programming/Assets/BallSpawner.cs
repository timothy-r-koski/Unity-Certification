using UnityEngine;
using System.Collections;

public class BallSpawner : MonoBehaviour {

    public GameObject projectle;
    public CameraRay aimer;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButtonDown(0))
        {
            Ray aimRay = aimer.GetAimRay();
            Debug.DrawRay(aimRay.origin, aimRay.direction, Color.red);
            Quaternion aimRotation = Quaternion.LookRotation(aimRay.direction);
            Instantiate(projectle, transform.position, aimRotation);
        }
    }
}
