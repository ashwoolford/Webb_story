using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fairing_01_rigid : MonoBehaviour
{

    public Rigidbody rb;

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

        if(distanceTravelled > 400){

            EnableRagdoll();

        }
        
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
