using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    private bool locked = true;
    // Create a boolean value called "opening" that can be checked in Update() 
    private bool opening;

    void Update()
    {
        // If the door is opening and it is not fully raised
        var heightOfDoor = 7.76f;
        if (opening && transform.position.y < heightOfDoor)
        {
            // Animate the door raising up
            transform.position = new Vector3(transform.position.x, transform.position.y + heightOfDoor / 3 * Time.deltaTime,
                transform.position.z);
        }
    }

    public void OnDoorClicked() {
        // If the door is clicked and unlocked
        // Set the "opening" boolean to true
        if (!locked)
        {
            opening = true;
        }
        // (optionally) Else
        // Play a sound to indicate the door is locked
        else
        {
            GetComponent<AudioSource>().Play();
        }
    }

    public void Unlock()
    {
        // You'll need to set "locked" to false here
        locked = false;
    }
}
