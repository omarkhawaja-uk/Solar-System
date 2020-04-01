using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

///-------------------------------------------------------------------------------
///   
///   Author:          Omar Khawaja                     
///   Description:     Used as a means to start the simulation scene once the 
///                    NASA video stops playing. Video Length = delayBeforeLoading 
///                    (in seconds).
///                   
///-------------------------------------------------------------------------------


public class LoadSceneVideoTimer : MonoBehaviour
{
    [SerializeField]
    private float delayBeforeLoading = 100f;
    [SerializeField]
    private string sceneNameToLoad;
    private float timeElapsed; 

    
    // Update is called once per 
    void Update()
    {
        // Setting time elapsed. 
        timeElapsed += Time.deltaTime; 

        // If length of the video has been reach. 
        if (timeElapsed > delayBeforeLoading)
        {
            // Then load the next scene. 
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }
}
