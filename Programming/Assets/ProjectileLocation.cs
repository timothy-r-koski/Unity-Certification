using UnityEngine;
using System.Collections;

public class ProjectileLocation : MonoBehaviour {

    public float speed = 5f;

	// Use this for initialization
	void Start () {

	}

    public void UpdatePosition() {
        Transform location = GetComponent<Transform>();
        location.position = location.position + new Vector3(0.0f, 0.0f, (speed * Time.deltaTime));
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
