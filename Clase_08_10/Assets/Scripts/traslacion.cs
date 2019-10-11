using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class traslacion : MonoBehaviour {

	public GameObject _centro;
    
    	public float _vel = 5;
    	// Use this for initialization
    	void Start () {
    		
    	}
    	
    	// Update is called once per frame
    	void Update () {
    		transform.RotateAround(_centro.transform.position, Vector3.up, _vel);
            //transform.Rotate(Vector3.up, Space.Self);
        }
}
