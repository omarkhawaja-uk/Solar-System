using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///------------------------------------------------------------------------------
///   
///   Author:          Omar Khawaja                     
///   Description:     Script for controlling cameras, and switching between Planets
///                    Press Keys: 1,2,3,4,5,6,7 for Planets & 'Tab' for viewing
///                    
///------------------------------------------------------------------------------


public class PlanetCameras : MonoBehaviour
{
    //cameras
    public GameObject view; 
    public GameObject Mercury;
    public GameObject Venus;
    public GameObject Earth;
    public GameObject Mars;
    public GameObject Jupiter;
    public GameObject Saturn;
    public GameObject Uranus;
    public GameObject Neptune;



    void Start()
    {
        view.SetActive(true);
      

    }

    void Update()
    {

        

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            view.SetActive(false);
            Mercury.SetActive(true);
            Venus.SetActive(false);
            Earth.SetActive(false);
            Mars.SetActive(false);
            Jupiter.SetActive(false);
            Saturn.SetActive(false);
            Uranus.SetActive(false);
            Neptune.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {

            view.SetActive(false);
            Mercury.SetActive(false);
            Venus.SetActive(true);
            Earth.SetActive(false);
            Mars.SetActive(false);
            Jupiter.SetActive(false);
            Saturn.SetActive(false);
            Uranus.SetActive(false);
            Neptune.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            view.SetActive(false);
            Mercury.SetActive(false);
            Venus.SetActive(false);
            Earth.SetActive(false);
            Mars.SetActive(true);
            Jupiter.SetActive(false);
            Saturn.SetActive(false);
            Uranus.SetActive(false);
            Neptune.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            view.SetActive(false);
            Mercury.SetActive(false);
            Venus.SetActive(false);
            Earth.SetActive(false);
            Mars.SetActive(false);
            Jupiter.SetActive(true);
            Saturn.SetActive(false);
            Uranus.SetActive(false);
            Neptune.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            view.SetActive(false);
            Mercury.SetActive(false);
            Venus.SetActive(false);
            Earth.SetActive(false);
            Mars.SetActive(false);
            Jupiter.SetActive(false);
            Saturn.SetActive(true);
            Uranus.SetActive(false);
            Neptune.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            view.SetActive(false);
            Mercury.SetActive(false);
            Venus.SetActive(false);
            Earth.SetActive(false);
            Mars.SetActive(false);
            Jupiter.SetActive(false);
            Saturn.SetActive(false);
            Uranus.SetActive(true);
            Neptune.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            view.SetActive(false);
            Mercury.SetActive(false);
            Venus.SetActive(false);
            Earth.SetActive(false);
            Mars.SetActive(false);
            Jupiter.SetActive(false);
            Saturn.SetActive(false);
            Uranus.SetActive(false);
            Neptune.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            view.SetActive(true);
            Mercury.SetActive(false);
            Venus.SetActive(false);
            Earth.SetActive(false);
            Mars.SetActive(false);
            Jupiter.SetActive(false);
            Saturn.SetActive(false);
            Uranus.SetActive(false);
            Neptune.SetActive(false);
        }
    }
}
