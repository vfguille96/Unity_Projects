using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAround : MonoBehaviour
{
    private const float _VEL = 10;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Vertical") * _VEL * Time.deltaTime, 0,
            Input.GetAxis("Horizontal") * _VEL * Time.deltaTime);

        Debug.LogFormat(gameObject.GetComponent<Rigidbody>().GetPointVelocity(gameObject.transform.position).magnitude
            .ToString());
    }

    private void OnCollisionEnter(Collision other)
    {
        if (gameObject.GetComponent<Rigidbody>().GetPointVelocity(gameObject.transform.position).magnitude >= 0.5F
            && other.gameObject.tag.Equals("Player"))
        {
            Destroy(other.gameObject, 0);
        }
    }
}