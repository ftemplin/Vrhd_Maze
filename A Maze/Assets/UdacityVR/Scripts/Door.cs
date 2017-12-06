using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked()
    bool locked = true;
    bool opening = false;
    public GameObject  hinge;
    bool open = false;

    // Create a boolean value called "opening" that can be checked in Update() 

    void Update() {
        // If the door is opening and it is not fully raised
        if (opening && !open)
        {
            transform.RotateAround(hinge.transform.position,Vector3.up,20*Time.deltaTime);
            var yrot = transform.rotation.eulerAngles.y;
            if(yrot > 90)
            {
                open = true;
            }
        }
            // Animate the door raising up
    }

    public void OnDoorClicked() {
        // If the door is clicked and unlocked
        if (!locked)
        {
            opening = true;
        }
            // Set the "opening" boolean to true
        // (optionally) Else
            // Play a sound to indicate the door is locked
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
        locked = false;
    }
}
