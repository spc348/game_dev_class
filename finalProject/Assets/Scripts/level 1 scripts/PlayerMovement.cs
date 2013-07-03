using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour
{
    
    public float turnSmoothing = 15f;   // A smoothing value for turning the player.
    public float speedDampTime = 0.1f;  // The damping for the speed parameter
	public float jumpHeight = 10f; // jumping distance
	public float playerSpeed = 20f;
    
    void FixedUpdate ()
    {
        // Cache the inputs.
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
		bool jump = Input.GetKeyDown (KeyCode.Space);
        
        MovementManagement(h, v, jump);
    }
   
    void MovementManagement (float horizontal, float vertical, bool jumping)
    {
        // If there is some axis input...
        if(horizontal != 0f || vertical != 0f)
        {
            // ... set the players rotation and set the speed parameter to 5.5f.
            Rotating(horizontal, vertical);
        }
		    Moving( horizontal, vertical, jumping);
    }
    
    
    void Rotating (float horizontal, float vertical)
    {
        // Create a new vector of the horizontal and vertical inputs.
        Vector3 targetDirection = new Vector3(horizontal, 0f, vertical);
        
        // Create a rotation based on this new vector assuming that up is the global y axis.
        Quaternion targetRotation = Quaternion.LookRotation(targetDirection, Vector3.up);
        
        // Create a rotation that is an increment closer to the target rotation from the player's rotation.
        Quaternion newRotation = Quaternion.Lerp(rigidbody.rotation, targetRotation, turnSmoothing * Time.deltaTime);
        
        // Change the players rotation to this new rotation.
        rigidbody.MoveRotation(newRotation);
		
    }
	
	void Moving ( float horizontal, float vertical, bool jumping)
	{
		Vector3 targetDirection = new Vector3(horizontal,0f,vertical);
		
		rigidbody.AddForce(targetDirection.normalized * playerSpeed * Time.deltaTime, ForceMode.VelocityChange);
		
		if (jumping)
		{
			Debug.Log ("jump");
		rigidbody.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);	
		}
		
	}
 
}