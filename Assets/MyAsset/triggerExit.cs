using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerExit : MonoBehaviour
{
    
    void OnTriggerExit (Collider collide) {
        Debug.Log("Enter Exit Trigger");
        triggerEvent.audioPlayed = false;
    }
}
