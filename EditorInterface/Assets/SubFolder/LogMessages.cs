using UnityEngine;
using System.Collections;

public class LogMessages : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Debug.Log("Hello World");
        Debug.LogWarning("I am a warning!");
        Debug.LogError("!!!I AM AN ERROR!!!");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
