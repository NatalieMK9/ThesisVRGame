/*
 * Meant to be used on the title screen to summon 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneChange : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "DebitCard")
        {
            SceneManager.LoadScene("vrfinalspace", LoadSceneMode.Additive);
        }
    }
}
