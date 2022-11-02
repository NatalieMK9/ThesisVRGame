/*
 * This code was intended to initate the ending sequence for the game, but due to framerate issues, scene transitions were omitted from the final product. When the user summons the keycard,
 * they can hold it to the keypad and win the game
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeypadScript : MonoBehaviour
{
    public GameObject DebitCard;
    public GameObject card;
    public AudioClip DoorOpen;
    
    void OnTriggerEnter(Collider other)
    {
        AudioSource beepbeep = GetComponent<AudioSource>();
        beepbeep.clip = DoorOpen;

        if (other.name == "DebitCard")
        {
            Debug.Log("Key has been tapped on the keypad");
            beepbeep.Play();
            //SceneManager.LoadScene("vrfinalspace", LoadSceneMode.Additive);
        }
    }
}
