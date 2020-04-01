using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

///------------------------------------------------------------------------------
///   
///   Author:          Omar Khawaja                     
///   Description:     Calculating the orbital velocities & Periods. 
///                    
///------------------------------------------------------------------------------

public class SetInitialOrbitalVelocity : MonoBehaviour
{
    // Setting variables and booleans. 
    // Also creating a custom Inspector for changing values. 

    [Header("Input Gravitational Constant:")]
    private float G = Gravity.G;    // Gravitational constant from Gravity script. 

    [Header("Leave Blank to Calculate Orbital Velocity:")]
    public Vector3 initialVelocity;

    [Header("Orbiting Around The Following Body:")]
    public GameObject orbitalParent; // The body you are choosing to orbit around. 

    [Header("Default is Elliptical Orbits, otherwise tick for:")]
    public bool circularOrbit; 
    public bool parabolicMotion;

    [Header("------- Method 1: Input Semi Major Axis Only ------")]
    [Header("Elliptical Orbit Only:")]
    public float semiMajor; //Semi Major axis.

    [Header("-- Method 2: Input Eccentricity & Semi Minor Axis --")]
    [Range(0, 1)]
    public float e; //Eccentricity of Orbit.
    public float semiMinor; //Semi Major Axis. 

    [Header("Ecliptic:")]
    public float angleOfInclination = 0f; // Angle of inclination ( given in radians). 

    [Header("Rotation:")]
    public float satelliteDaysInYear = 365f; // Amount of Earth days the satellite/body experiences in a year.
    public float satelliteEarthDay = 1f;

    private float rotationalSpeed; // Rotational Speed.
    private Rigidbody rb;

    [Header("Input Axial Tilt:")] // Axial Tilt. 
    public float axialTilt;



    // Start is called before the first frame update
    void Start()
    {
        G = Gravity.G;
        rb = this.GetComponent<Rigidbody>();

        // Setting the Initial Velocity at the start. 
        SetVelocity(initialVelocity);
        if (initialVelocity == Vector3.zero)    // If the Initial Velocity is not inputted in the inspector.    
        {
            angleOfInclination = -angleOfInclination; // Flipping values so that positive angle = positive inclination. 
            // Angle of Inclination. 
            SetOrbitalVelocity(new Vector3(Mathf.Sin(angleOfInclination) * 1f, Mathf.Cos(angleOfInclination) * 1f, 0f));
        }

        // Setting method at the start. 
        GetPeriod();
    }



    //Calculating the required initial Orbital Velocity 
    public void SetOrbitalVelocity(Vector3 normal)
    {
        Vector3 orbitalVelocity;
        rb = this.GetComponent<Rigidbody>();
        float distance = Vector3.Distance(orbitalParent.transform.position, transform.position); // Finding the distance between this body and the orbital parent object. 
        Vector3 r = orbitalParent.transform.position - rb.position; // Position of sun minus position of this body. 

        Vector3 unitTangent = Vector3.Cross(normal, r.normalized); // Finding the unit tangent to give direction, and normalizing the unit tangent.

        // If eccentricity is inputted. 
        if (e > 0)
        {
            semiMajor = semiMinor / Mathf.Sqrt(1 - Mathf.Pow(e, 2f)); // Finding Semi-Major axis through eccentricity.
        }

        // If circular orbit is chosen. 
        if (circularOrbit)
        {
            semiMajor = distance; // Sets the Highest point to the current point to get a circular orbit.
        }

        // If parabolic motion is chosen. 
        if (parabolicMotion)
        {
            orbitalVelocity = Mathf.Sqrt(2 * G * orbitalParent.GetComponent<Rigidbody>().mass / distance) * unitTangent;    // Formula for the velocity of a Parabolic trajectories. 
            initialVelocity = orbitalVelocity + orbitalParent.GetComponent<Rigidbody>().velocity;  // Pluses orbital parent velocity.
        }

        // Default is elliptical orbits. 
        else
        {
            orbitalVelocity = Mathf.Sqrt(G * orbitalParent.GetComponent<Rigidbody>().mass * ((2 / distance) - (1 / semiMajor))) * unitTangent; // Using the vis-viva equation to get the velocity. 
            initialVelocity = orbitalVelocity + orbitalParent.GetComponent<Rigidbody>().velocity; // Pluses orbital parent velocity.
        }

        //Set       
        SetVelocity(initialVelocity);

        // Axial Tilt of the body
        this.transform.Rotate(unitTangent, this.axialTilt);

        //Print
        Debug.Log(this.rb.name + "'s Velocity:  " + initialVelocity.magnitude);

        // Debugging. 
        if (this.initialVelocity == null)
        {
            Debug.Log("Error:" + this.rb.name + "'s  initial velocity is null");
        }
    }



    // Setting the velocity. 
    public void SetVelocity(Vector3 velocity)
    {
        rb.velocity = velocity;
    }



    // Calculating the period.
    public void GetPeriod()
    {
        float T;  // Period
        float orbitDistance;  // Orbital distance. 

        // If circular orbits is chosen. 
        if (circularOrbit)
        {
            orbitDistance = Vector3.Distance(orbitalParent.transform.position, transform.position);
        }

        // Default for elliptical orbits. 
        else
        {
            orbitDistance = semiMajor;
        }

        // Formula to calculate the period of the body. 
        T = 2 * Mathf.PI * Mathf.Sqrt(Mathf.Pow(orbitDistance, 3f) / (G * orbitalParent.GetComponent<Rigidbody>().mass));

        // Formula for rotational speed of the body. 
        rotationalSpeed = 360f / (T / (satelliteDaysInYear / satelliteEarthDay));

        // Printing the period. 
        Debug.Log(this.gameObject.name + "'s period is " + T);
    }


    // Making the bodies rotate using the rotational speed, about its axis. 
    public void Update()
    {
        transform.RotateAround(transform.position, transform.up, Time.deltaTime * rotationalSpeed);
    }
}
