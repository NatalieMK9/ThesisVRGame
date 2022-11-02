/*
 * This is the code that activates when the red key is near the lock to summon the keycard
 * When the collider for the red key comes into contact with the lock's collider, it summons a keycard at the lock.
 * This code also makes sure only one keycard is summoned
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockBehavior : MonoBehaviour
{
    public GameObject DebitCard;
    public GameObject card;
    public bool summon = false;

    void OnTriggerEnter(Collider other)
    {
        //summon makes sure that only one keycard appears
        if (other.name == "redkey" && summon == false)
        {
            Debug.Log("Key has been put in lock");
            CreateDebitCard();
            card.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
            card.transform.position = new Vector3(7.94f, 1.413f, 6.843f);
            summon = true;
        }
    }
    public void CreateDebitCard()
    {
        card = Instantiate(DebitCard);
    }
}