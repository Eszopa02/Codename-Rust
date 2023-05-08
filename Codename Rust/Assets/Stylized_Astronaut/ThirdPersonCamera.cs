using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Credits:
//Script created by Sebastian Lague - https://www.youtube.com/watch?v=sNmeK3qK7oA&t=647s

public class ThirdPersonCamera : MonoBehaviour
{
    public float mouseSensitivity = 10;

    float yaw;
    float pitch;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        yaw += Input.GetAxis ("Mouse X") * mouseSensitivity;
        pitch -= Input.GetAxis ("Mouse Y") * mouseSensitivity;

        Vector3 targetRotation = new Vector3(pitch, yaw);
        transform.eulerAngles = targetRotation;
    }
}
