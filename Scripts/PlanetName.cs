using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///------------------------------------------------------------------------------
///   
///   Author:          Omar Khawaja                     
///   Description:     Script for placing name label above bodies. 
///                    Labels will follow the bodies. 
///                    
///------------------------------------------------------------------------------

public class PlanetName : MonoBehaviour
{
    [Header("Text object goes here:")]
    public GameObject label; // The Name Label
    [Header("Body text will follow goes here:")]
    public GameObject thisBody; // The body that the name label will be following.
    [Header("Main Camera goes here:")]
    public Camera thisCamera; 

    void Start()
    {
        label.transform.rotation = thisCamera.transform.rotation; // Makes the text face the Main Camera. 
    }

    public int down; // Default is zero. Made this public so I bring the Moon text lower than the Earth's text. 
    void Update()
    {
        label.transform.position = this.thisBody.transform.position + Vector3.up * 100f + Vector3.left * 150f + Vector3.down * down; // Updates the positoin of the label. 
    }
}
        