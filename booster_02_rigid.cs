using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class booster_02_rigid : MonoBehaviour
{

	public Rigidbody rb;

	public float speed = 2f;

    float distanceTravelled = 0;
    Vector3 lastPosition;
    // Start is called before the first frame update
    void Start()
    {

    	lastPosition = transform.position;
        rb = GetComponent<Rigidbody>();

        DisableRagdoll();
        
    }

    // Update is called once per frame
    void Update()
    {

    	distanceTravelled += Vector3.Distance(transform.position, lastPosition);
        lastPosition = transform.position;

        if(distanceTravelled > 100){

            EnableRagdoll();
         	transform.Rotate(0, speed, 0);

        }

    	

    	Debug.Log(distanceTravelled);
        
    }


    void EnableRagdoll() {
         rb.isKinematic = false;
         rb.detectCollisions = true;
     }
     void DisableRagdoll() {
         rb.isKinematic = true;
         rb.detectCollisions = false;
     }
}
