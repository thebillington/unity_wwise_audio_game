using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private AudioController audioController = null;
    private float speed = .2f;
    private float rotation_speed = 90f;

    // Start is called before the first frame update
    void Start()
    {
        audioController = gameObject.GetComponent<AudioController>();        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate (Vector3.forward * -rotation_speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate (Vector3.forward * rotation_speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
            audioController.triggerFootsteps();
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
    }
}
