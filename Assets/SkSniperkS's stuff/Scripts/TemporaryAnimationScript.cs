using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemporaryAnimationScript : MonoBehaviour {
    Animator animator;
    CharacterController controller;

    private void Start()
    {
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<CharacterController>();
    }

    void Update () {
        animator.SetBool("isGrounded", controller.isGrounded);
	}
}
