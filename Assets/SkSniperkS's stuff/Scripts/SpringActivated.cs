using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringActivated : MonoBehaviour {

    [SerializeField] Vector3 springDistance;
    CharacterController controller;

    private void Start()
    {
        enabled = false;
        springDistance = transform.TransformDirection(springDistance);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Player"))
        {
            controller = other.GetComponentInParent<CharacterController>();
            enabled = true;
        }
    }

    private void Update()
    {
        Vector3 currentLeap = springDistance * Time.deltaTime;
        controller.Move(currentLeap);
    }

    private void LateUpdate()
    {
        if (controller.isGrounded)
        {
            enabled = false;
        }
    }
}
