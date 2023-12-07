using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor.PackageManager;
using UnityEngine;

public class ACPauseAnim : MonoBehaviour {

    [SerializeField] Animator animator;
    //if animator is not assigned, then the script will automatically check for an animator component on it's assigned object
    void Start() {
        if (animator == null) {
            animator = GetComponent<Animator>();
            if (animator == null) {
                Debug.LogError("No animator found. Please either add an Animator component to the GameObject, or define an Animator in the script component");
            }
        }
    }


    // these functions can be called with the Object:Send Message action
    void TurnOn() {
        animator.speed = 1;
    }
    void TurnOff() {
        animator.speed = 0;
    }

    void SetSpeed(int speed) {
        animator.speed = speed;
    }

}
