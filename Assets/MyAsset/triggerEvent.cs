using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerEvent : MonoBehaviour
{
    public Animator anima;
    public AudioSource audioSource;
    // public AudioClip clip;
    public static bool audioPlayed = false;

    void Start () {
        audioSource.GetComponent<AudioSource>();

    }

    void OnTriggerEnter (Collider other) {
      if (other.tag == "Player") {
        if (audioPlayed == false) {
            audioPlayed = true;
            Debug.Log("Enter If Loop");
            anima.SetBool("active 0", true);
            // audioSource.PlayOneShot(audioSource.clip, 1f);
            if (!audioSource.isPlaying) {
                audioSource.Play();
            }
        }
        Debug.Log("Exit If Loop");
      }
  }

    void OnTriggerExit (Collider other) {
      if (other.tag == "Player") {
        Debug.Log("Enter Exit Trigger");
        anima.SetBool("active 0", false);
        audioPlayed = false;
      }
    }
}
