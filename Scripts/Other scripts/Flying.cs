using System.Collections;
using System.Collections.Generic;
using UnityEngine;

///------------------------------------------------------------------------------
///   
///   Author:          Omar Khawaja                     
///   Description:     Spaceship controller script. 
///                    
///------------------------------------------------------------------------------
public class Flying : MonoBehaviour
{
    public float movementSpeed = 100f;  // Speed of the Spaceship/Shuttle, editable in inspector. 
    public float revertSpeed = 100f;    // When no longer moving, can revert back to original speed. 
    public float shiftSpeed = 150f;     // Higher than movement.
    public float controlSpeed = 50f;    // How fast turning controls work.

    public float horizSensitivity = 2f; // Horizontal sensitivity.
    public float vertSensitivity = 2f;  // Vertical sensitivity.


    private float yaw = 0f;    // Implemented for camera movement (i.e aircraft yaw). 
    private float pitch = 0f;  // Implemented for camera movement (i.e aircraft pitch).

    public Animator getAnim; // For the animations used in flying.

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;  // Locking the cursor so it doesn't move around the screen.
        Cursor.visible = false;  // Hiding the cursor from the screen so it is not visible. 
    }


    void Update()
    {
        // Attaching the yaw value to the mouse movement, which allows  mouse to move with camera movement - X axis is the horizontal plane
        yaw += horizSensitivity * Input.GetAxis("Mouse X");
        // Y axis of the mouse is the vertical plane. 
        pitch -= vertSensitivity * Input.GetAxis("Mouse Y");

        // Euler angles will allow for smooth angle transitions. This line sets how the camera is going to move whilst the Mouse X and Y are updated. 
        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);   


        // If statements to Check which button is pressed and let that determine how/where to move in space. 
        if (Input.GetKey(KeyCode.LeftShift))
        {
            // Movement speed now equals shift speed if left shift pressed -- boosting. 
            movementSpeed = shiftSpeed;            
        }
        else
        {
            // If a key is not pressed then movement speed is then reset, prevent cruising.  
            movementSpeed = revertSpeed;            
        }





        // Transform the position object to the forward position when key W,A,S or D is pressed, in seconds passed within the game editor. Increased by Control speed.
        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += transform.forward * Time.deltaTime * controlSpeed; // For key 'W'
            getAnim.SetBool("Down", true); // Set. 
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition -= transform.right * Time.deltaTime * controlSpeed; // For key 'A'
            getAnim.SetBool("Left", true);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition -= transform.forward * Time.deltaTime * controlSpeed; // For key 'S'
            getAnim.SetBool("Up", true);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += transform.right * Time.deltaTime * controlSpeed; // For key 'D'
            getAnim.SetBool("Right", true);
        }

        // Required For animations. 

        // Checking none of the W,A,S,D keys are being pressed down. 
        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D))         {
            getAnim.SetBool("Forward", true);   // And Forward is True. 
            getAnim.SetBool("Down", false);
            getAnim.SetBool("Up", false);
            getAnim.SetBool("Left", false);
            getAnim.SetBool("Right", false);
        }
        else
            // Otherwise set the Forward animation as false. 
            getAnim.SetBool("Forward", false);

        // Unlocking & making visible the cursor/mouse if the 'esc' or 'backspace button is pressed. 
        // So that cursor is not locked when going into the main menu. 
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Backspace))
        {

            Cursor.lockState = CursorLockMode.None; // Un-locking. 
            Cursor.visible = true; // Visible. 
        }
    }
}
