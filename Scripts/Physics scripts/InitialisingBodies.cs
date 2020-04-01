using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///------------------------------------------------------------------------------
///   
///   Author:          Omar Khawaja                     
///   Description:     Initialising the bodies position and start order. 
///                    
///------------------------------------------------------------------------------
public class InitialisingBodies : MonoBehaviour
{
    [Header(" ")]
    [Header("Drag & Drop Planets In Order:")]
    [Header("Keep These Bodies Initially Disabled")]

    public GameObject Mercury;
    public GameObject Venus;
    public GameObject Earth;
    public GameObject EarthMoon;
    public GameObject Mars;
    public GameObject Jupiter;
    public GameObject Saturn;
    public GameObject Uranus;
    public GameObject Neptune;




    void Awake()
    {
        // Intilaising the Perihelion of all bodies, useful for scaling in the future. Distances are set in ratio to the Earth and in AU x10^3. 
        // Keeping everything in floats - to avoid future issues. 
        float scaleFactor = 1000f;
        Mercury.transform.position = new Vector3(0, 0, 0.313f * scaleFactor);
        Venus.transform.position = new Vector3(0, 0, 0.731f * scaleFactor);
        Earth.transform.position = new Vector3(0, 0, 1f * scaleFactor);
        EarthMoon.transform.position = new Vector3(0, 0, 1.00247f * scaleFactor);
        Mars.transform.position = new Vector3(0, 0, 1.41f * scaleFactor);
        Jupiter.transform.position = new Vector3(0, 0, 5.03f * scaleFactor);
        Saturn.transform.position = new Vector3(0, 0, 9.2f * scaleFactor);
        Uranus.transform.position = new Vector3(0, 0, 18.64f * scaleFactor);
        Neptune.transform.position = new Vector3(0, 0, 30.22f * scaleFactor);
    }


    private void Start()
    {
        // Intilaising the order in which I want the Game Objects/Bodies to initialise. They start-off disabled. 
        // This is especially important for Moons. 
        Mercury.SetActive(true);
        Venus.SetActive(true);
        Earth.SetActive(true);
        EarthMoon.SetActive(true);
        Mars.SetActive(true);
        Jupiter.SetActive(true);
        Saturn.SetActive(true);
        Uranus.SetActive(true);
        Neptune.SetActive(true);
    }
}
