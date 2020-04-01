//Old version

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInitialOrbitalVelocity : MonoBehaviour
{

    //Private 
    private Rigidbody rb;
    private float r;

    // Accessed by user 
    public Vector3 initialVelocity;                         
    public Vector3 OrbitNormal;                     
    public float G = Gravity.G;                     

    // Constants
    const float SunMass = 333000.0f;


    // Start is called before the first frame update
    void Start()
    {
      
        
        rb = this.GetComponent<Rigidbody>();

        SetVelocity(initialVelocity);               
        if (initialVelocity == Vector3.zero)        
        {
            SetOrbitalVelocity(OrbitNormal);
        }

    }
    //Calculating the required initial Orbial Velocity 
    public void SetOrbitalVelocity(Vector3 normal)
    {
        rb = this.GetComponent<Rigidbody>();       
           
        Vector3 r = GameObject.Find("Sun").transform.position - rb.position;
        float magnitude = r.magnitude;                                       
        Vector3 unitTangent = Vector3.Cross(normal, r);          
        //Circular Orbits 
        Vector3 orbitalVelocity = Mathf.Sqrt(G * SunMass / Mathf.Pow(magnitude, 3)) * unitTangent; //  r^3 IF the  unittangent  not normalised.
        
       

        //Set 
        initialVelocity = orbitalVelocity;
        
        SetVelocity(initialVelocity);

    }


    public void SetVelocity(Vector3 velocity)
    {
        rb.velocity = velocity;
    }

}
