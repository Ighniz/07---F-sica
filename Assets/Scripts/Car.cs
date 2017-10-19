using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {

    public WheelJoint2D joint;

	// Use this for initialization
	void Start () {
        joint.useMotor = true;
	}
	
	// Update is called once per frame
	void Update () {
        JointMotor2D myMotor = joint.motor;
        myMotor.motorSpeed = Input.GetAxis("Horizontal") * 500;
        joint.motor = myMotor;
    }
}
