using UnityEngine;
using UnityEditor;
using System.IO;

///------------------------------------------------------------------------------
///   
///   Author:          Omar Khawaja                     
///   Description:     Retrieving desired data from the simulation, e.g position.
///                    
///------------------------------------------------------------------------------

public class Data : MonoBehaviour
{
    // The body in which I want to retrieve data from. 
    public GameObject thisBody;

    // Using a TextWriter for writing characters to a stream. 
    private StreamWriter writer;

    private void Start()
    {
        // File path. 
        string path = "Assets/test2.txt";
        writer = new StreamWriter(path);
        // Title. 
        writer.WriteLine("Position, time");  
    }

    private void FixedUpdate()
    {
        // Called every fixed frame-rate frame. 0.02 second intervals. 
        WriteString();
    }


    void WriteString()
    {
        // Writing. 
        writer.WriteLine(thisBody.transform.position.magnitude + "," + Time.fixedTime);
        //  Clears the buffer, stream will remain open. Writes from the text stream into the file. 
        writer.Flush(); 
    }
}

