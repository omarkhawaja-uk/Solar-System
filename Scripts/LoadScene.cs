using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

///------------------------------------------------------------------------------
///   
///   Author:          Omar Khawaja                     
///   Description:     Loads the next desired scene
///                    
///------------------------------------------------------------------------------
public class LoadScene : MonoBehaviour
{
    public void SceneLoader(string SceneName)
    {
        //Loads screen by taking its name. 
        SceneManager.LoadScene(SceneName);
    }
}
