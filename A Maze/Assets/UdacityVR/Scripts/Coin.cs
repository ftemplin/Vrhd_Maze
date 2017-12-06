using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
    public Transform Poof;
    

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
        Instantiate(Poof, transform.position, Poof.rotation);

        // Make sure the poof animates vertically
        // Destroy this coin. Check the Unity documentation on how to use Destroy
        Destroy(gameObject);
    }

}
