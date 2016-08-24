using UnityEngine;
using System.Collections;

public class ProjectileLocation : MonoBehaviour {

    public float force = 5f;

	// Use this for initialization
	void Start () {

	}

    public void UpdatePosition() {
        Rigidbody location = GetComponent<Rigidbody>();
        location.AddForce(new Vector3(0.0f, 0.0f, force));
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
