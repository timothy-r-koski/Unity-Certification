using UnityEngine;
using System.Collections;

public class AverageCalc : MonoBehaviour {

    public float inputOne;
    public float inputTwo;

	// Use this for initialization
	void Start () {
        print("Average of " + inputOne + " and " + inputTwo + " = " + Average(inputOne, inputTwo));
	}

    public float Average(float numberOne, float numberTwo) 
    {
        return (numberOne + numberTwo) / 2;
    }

	// Update is called once per frame
	void Update () {
	
	}
}
