using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mc_sky_rotation : MonoBehaviour
{
    // Start is called before the first frame update


    public float RotateSpeed = 1.2f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    	RenderSettings.skybox.SetFloat("_Rotation", Time.time * 0.4f);
            
    }
}
