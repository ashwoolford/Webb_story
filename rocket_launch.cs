using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket_lunch : MonoBehaviour
{

	Vector3 force;
	Vector3 relativeTorque;
	float liftSpeed = 0.2f;
	float turnSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    	GetComponent<ConstantForce>().force = Vector3.up * liftSpeed;
    	
        
    }
}
