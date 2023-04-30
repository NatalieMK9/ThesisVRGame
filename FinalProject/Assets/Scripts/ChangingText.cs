/*CHANGINGTEXT.CS
    This code changes the display on the big monitor at the front at certain intervals.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangingText : MonoBehaviour

{
    public Text ScreenText;
    public float timeRemaining = 660;
    public bool timerIsRunning = true;

    private void Start()
    {
        timerIsRunning = true;
    }

    void Update()
    {
        //deltaTime refers to the number of seconds that have passed since the last frame. timeRemaining is updated with each frame with the amount of seconds since the last frame removed
        timeRemaining -= Time.deltaTime;
        if (timerIsRunning)
        {
            if (timeRemaining < 625 && timeRemaining > 620)
            {
                ScreenText.text = "We're thrilled to have you onboard as our newest ensign!";
            }
            if (timeRemaining < 620 && timeRemaining > 615)
            {
                ScreenText.text = "Unfortunatley, you have managed to lock yourself in this room.";
            }
            if (timeRemaining < 615 && timeRemaining > 610)
            {
                ScreenText.text = "Try to get out in ten minutes or less!";
            }
            if (timeRemaining < 610 && timeRemaining > 605)
            {
                ScreenText.text = "Try exploring the room to find a way out.";
            }
            if (timeRemaining < 605 && timeRemaining > 600)
            {
                ScreenText.text = "Good luck, ensign!";
            }
            if (timeRemaining < 600 && timeRemaining > 0)
            {
                ScreenText.text = "Time Remaining:" + (string.Format("{0:N2}", timeRemaining)) + "Points Possible:" + (string.Format("{0:N2}", (timeRemaining * 2)));
            }
            //lose condition
            if (timeRemaining < 0)
            {
                ScreenText.text = "It's been ten minutes, please remove your headset.";
                timerIsRunning = false;
            }
        }
    }
}
