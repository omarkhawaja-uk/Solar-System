using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

///------------------------------------------------------------------------------
///   
///   Author:          Omar Khawaja                     
///   Description:     Returns back to the Main menu, by pressing a specific key 
///                    
///------------------------------------------------------------------------------

public class RestartScene : MonoBehaviour
{
    // In Update, to check for the Key press. 
    void Update()
    {
        // If the 'esc' / 'Backspace' button is pressed, return back to the Main menu scene - build (0). 
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Backspace))
        {
            // The '0' represents the first scene, i.e. the Main menu.
            SceneManager.LoadScene(0);
            // Re-enabling the cursor, encase if it disabled from the Space Ship. 
            Cursor.visible = true;
        }

    }

}
