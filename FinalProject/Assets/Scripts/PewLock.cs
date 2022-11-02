/*
 *This is the code that activates when the blue key is near the lock to summon the pistol
 * When the collider for the blue key comes into contact with the lock's collider, it summons a keycard at the lock.
 * This code also makes sure only one pistol is summoned
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PewLock : MonoBehaviour
{
    public GameObject PewPew;
    public GameObject pew;
    public bool appear = false;

    void OnTriggerEnter(Collider other)
    {
        //checks if its the blue key and if a pistol has already appeared
        if (other.name == "bluekey" && appear == false)
        {
            Debug.Log("The PewPew has been summoned");
            CreateDebitCard();
            pew.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            pew.transform.position = new Vector3(12.116f, 2.136f, -4.628f);
            appear = true;
        }
    }

    //summons the pistol
    public void CreateDebitCard()
    {
        pew = Instantiate(PewPew);
    }
}
