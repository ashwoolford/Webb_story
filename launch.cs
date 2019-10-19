using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launch : MonoBehaviour
{

	Vector3 force;
	float liftSpeed = 0.2f;


    float distanceTravelled = 0;
    Vector3 lastPosition;


    // Start is called before the first frame update
    void Start()
    {

        lastPosition = transform.position;
        
    }

    // Update is called once per frame
    void Update()
    {

    	GetComponent<ConstantForce>().force = Vector3.up * liftSpeed;
        distanceTravelled += Vector3.Distance(transform.position, lastPosition);
        lastPosition = transform.position;

        if(distanceTravelled > 200 && distanceTravelled < 250){
            transform.Rotate(0.2f, 0,0);
        }
    	
        
    }
}
