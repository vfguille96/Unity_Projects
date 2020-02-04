using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraFP : MonoBehaviour
{
    public float sensibilityX;
    public float sensibilityY;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles += new Vector3(-Input.GetAxis("Mouse Y") * sensibilityY,
            Input.GetAxis("Mouse X") * sensibilityX, 0);
    }
}