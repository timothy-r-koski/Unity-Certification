using UnityEngine;
using System.Collections;

public class ProjectileMovement : MonoBehaviour {

    ProjectileLocation projectile;

    // Use this for initialization
    void Start () {
        projectile = GetComponent<ProjectileLocation>();
	}

    void FixedUpdate() {
        projectile.UpdatePosition();
    }

	// Update is called once per frame
	void Update () {
       
    }
}
