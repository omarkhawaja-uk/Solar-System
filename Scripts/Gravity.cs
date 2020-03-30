using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///------------------------------------------------------------------------------
///   
///   Author:          Omar Khawaja                     
///   Description:     Applying Newtons Law of Gravitation: F = G * m1 * m2 / r^2    
///                    
///------------------------------------------------------------------------------


// MonoBehaviour is the base class. 
public class Gravity : MonoBehaviour
{
    Rigidbody rb;   // Using Rigidbody - Unity's built in Physics component. And creating object rb.                          
    public static float G = 100f;  // Gravitational constant G, static so it can be accessed in other scripts 
    public static List<Gravity> GVRobj;  // Creating a list containing Gravity - called GVRobj

    // Using Unity's Awake, for initialising variables / game state before the game starts.
    private void Awake()
    {
        // Getting the component Rigidbody. This body is rb. 
        rb = GetComponent<Rigidbody>();

        // For initializations, if the list is empty. 
        if (GVRobj == null) GVRobj = new List<Gravity>();
        // Create a new list
        GVRobj.Add(this);

    }

    // FixedUpdate has the frequency of the physics system. 0.02 seconds intervals. 
    private void FixedUpdate()
    {

        // Apply Attract for each  object (obj) of Gravity within list GVRobj. 
        foreach (Gravity obj in GVRobj)
        {

            if (obj != this)    // If body is not this.
                Attract(obj);   // Then apply the Attract method. 
        }

    }

    // Attract Function. Object/Body to attract with rb (this body). 
    private void Attract(Gravity objToAttract)
    {
        Rigidbody rbObjToAttract = objToAttract.rb;

        // Using Unity's Vector3 component for (x,y,z) co-ord and the .position to grab (x,y,z) position of the object.
        // Finding the direction of mass1 and mass2. 
        Vector3 direction = rb.position - rbObjToAttract.position;
        float distance = direction.magnitude;   //  // Magnitude computes sqrt[x^2 + y^2 + z^2] of the direction vector.                                              
        if (distance == 0) return;  // If distance is equivalent to zero, return to avoid errors. Encase two objects overlap.                                                         

        // Using Newton's Eq of Grav Force to find the Magnitude of the Force between two objects. 
        // Using Unity's Rigidbody & mass, to create mass for the two bodies, m1 and m2.  
        float forceMagnitude = G * ((rb.mass * rbObjToAttract.mass) / Mathf.Pow(distance, 2));

        // To get Force: Magnitude of Force needs to applied with direction vector, i.e normalized direction. 
        Vector3 force = direction.normalized * forceMagnitude;

        rbObjToAttract.AddForce(force);      //Adding the force.                                                  
    }
}