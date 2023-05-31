using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    
    private AudioController audioController = null;
    private float speed = .2f;
    private float rotationSpeed = 90f;

    void Start() {
        audioController = gameObject.GetComponent<AudioController>();       
    }

    public void checkKeyPress() {
        if (Input.GetKey(KeyCode.RightArrow)) {
            transform.Rotate (Vector3.forward * -rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            transform.Rotate (Vector3.forward * rotationSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow)) {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            audioController.triggerFootsteps();
        }

        if (Input.GetKey(KeyCode.DownArrow)) {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
            audioController.triggerFootsteps();
        }
    }
}
