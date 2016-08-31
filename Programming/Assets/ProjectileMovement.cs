using UnityEngine;
using System.Collections;

public class ProjectileMovement : MonoBehaviour {

    ProjectileLocation projectile;
    bool hasFired = false;

    // Use this for initialization
    void Start () {
        projectile = GetComponent<ProjectileLocation>();
	}

    void FixedUpdate() {
        if (!hasFired)
        {
            projectile.UpdatePosition();
            hasFired = true;
        }
        else
        {
            projectile.UpdateFiredPosition();
        }
         
    }

	// Update is called once per frame
	void Update () {
     
    }
}
