using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    AudioSource audioSource;        // placed outside of the functions to be accessible to any function

    // Start is called before the first frame update
    void Start()
    {
        // Find the audio source component on the cube -- gets a reference to Audio Source component
        audioSource = GetComponent<AudioSource>();
    }

    void ToggleAudio()      // toggles the audio when Z button is pressed
    {
        // Input.GetButtonDown("Jump"))    // player presses the "Jump"/spacebar key

        if (Input.GetKeyDown(KeyCode.Z))    // player pressed the Z key
        {
            if (audioSource.isPlaying == true)  // checks if clip is playing
            {
                audioSource.Stop();   // stops the clip
            }
            else
            {
                audioSource.Play();    // plays the clip
            }
        }

        // audioSource.PlayDelayed(< some time in seconds >);    // starts clip after a delay

        /* 
          To change/switch between audio clips of an audio source
          audioSource.clip = newClip;
          audioSource.Play();
        */
    }

    // Update is called once per frame
    void Update()
    {
        ToggleAudio();    // calls the ToggleAudio method continuously
    }
}
