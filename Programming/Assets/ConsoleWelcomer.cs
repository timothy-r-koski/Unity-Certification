using UnityEngine;
using System.Collections;

public class ConsoleWelcomer : MonoBehaviour {

    

    
	// Use this for initialization
	void Start () {
        int anInteger = 1000;
    float someFloat = 2.5f;
    float sum = anInteger + someFloat;
    float mean = sum / 2;

        print("Hello my name is Tim Koski");
        print("Welcome to my program");

        print("anInteger =" + anInteger);

        print("someFloat = " + someFloat);
        print("sum = " + sum);
        print("mean = " + Average(sum, 2));
        print("square = " + Square(someFloat));
	}

    float Square(float numToSqr) {
        return numToSqr + numToSqr;
    }

    float Average(float sum, float numOfNumbers) {
        return sum / numOfNumbers;
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
