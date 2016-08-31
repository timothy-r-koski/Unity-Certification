using UnityEngine;
using System.Collections;

public class ProjectileLocation : MonoBehaviour {

    public float force = 20f;
    public float gravity = 9.41f;
    public float duration = 5;
    float startTime;

    // Use this for initialization
    void Start () {
        startTime = Time.time;
	}

    public void UpdatePosition() {
        Rigidbody location = GetComponent<Rigidbody>();
        location.AddForce(transform.forward * force, ForceMode.Impulse);
    }

    public void UpdateFiredPosition()
    {
        Rigidbody location = GetComponent<Rigidbody>();
        location.AddForce(new Vector3(0.0f, gravity, 0.0f), ForceMode.Force);
    }

    // Update is called once per frame
    void Update () {
        if (startTime + duration < Time.time)
        {
            Destroy(gameObject);
        }
    }
}
