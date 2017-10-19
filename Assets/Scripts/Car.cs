using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {

    public HingeJoint2D joint;

	// Use this for initialization
	void Start () {
        joint.useMotor = true;
        JointMotor2D myMotor = joint.motor;
        myMotor.motorSpeed = 500;
        joint.motor = myMotor;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
