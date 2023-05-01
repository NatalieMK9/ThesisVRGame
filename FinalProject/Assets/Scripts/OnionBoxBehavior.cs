/*
 * Onion minigame tracker
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnionBoxBehavior : MonoBehaviour
{
    public GameObject jarst_onion;
    public GameObject onion;
    public int score = 0;
    public Text MinigameText;
    public float countdown = 6;

    void OnTriggerEnter(Collider other)
    {
        //when onion enters box, make new onion
        if (other.name == "onionshelf")
        {
            Debug.Log("onion in the box");
            NewOnion();
            onion.transform.localScale = new Vector3(1.533f, 1.533f, 1.533f);
            onion.transform.position = new Vector3(0.21f, 0.15f, 0.1f);
            score++;
            Debug.Log(score);
            countdown -= Time.deltaTime;
            if (countdown > 0) {
                MinigameText.text = "Restocking! How fast can you put the right number of items in their right basket?";
            }
            MinigameText.text = (string.Format("{0:N2}", score));
        }
    }
    public void NewOnion()
    {
        onion = Instantiate(jarst_onion);
    }
}