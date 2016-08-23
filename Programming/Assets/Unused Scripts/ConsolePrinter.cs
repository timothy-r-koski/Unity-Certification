using UnityEngine;
using System.Collections;

public class ConsolePrinter : MonoBehaviour
{
    public Vector3 currentLocation;

	// Use this for initialization
	void Start () {
        Vector3 home = new Vector3(0.0f, 0.0f, 0.0f);
        Vector3 distanceToHome = currentLocation - home;
        print("current location = " + currentLocation);
        print("home location = " + home);
        print("distance from home:" + distanceToHome.magnitude);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
