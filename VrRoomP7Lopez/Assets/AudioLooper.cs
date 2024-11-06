using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioLooper : MonoBehaviour
{
    public AudioSource audioSource; // Assign your AudioSource in the inspector
    public float delayTime = 2f; // Time in seconds before looping

    private void Start()
    {
        StartCoroutine(LoopAudio());
    }

    private IEnumerator LoopAudio()
    {
        while (true) // This will create an infinite loop
        {
            audioSource.Play(); // Play the audio
            yield return new WaitForSeconds(audioSource.clip.length + delayTime); // Wait for the audio length + delay
        }
    }
}
