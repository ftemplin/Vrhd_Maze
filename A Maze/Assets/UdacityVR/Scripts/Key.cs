using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    //Create a reference to the KeyPoofPrefab and Door
    public GameObject KeyPoofPrefab;

    public GameObject Door;

    public void OnKeyClicked()
    {
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        var coinPoof = Instantiate(KeyPoofPrefab, transform.position, Quaternion.Euler(-90, 0, 0), transform.parent);

        // Call the Unlock() method on the Door
        var doorComponent = Door.GetComponent<Door>();
        doorComponent.Unlock();
        // Set the Key Collected Variable to true

        // Destroy the key. Check the Unity documentation on how to use Destroy
        Destroy(gameObject);
    }

    void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
        transform.rotation = Quaternion.Euler(0,1,0) * transform.rotation;
	}

}
