using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveA : MonoBehaviour
{
    // Start is called before the first frame update
    private const float MIN = -1.173F;
    private const float MAX = 1.218F;
    public float _posZ = 0;
    private float _vel = 4F;

    void Start()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        var transform1 = transform;
        _posZ += Input.GetAxis("VerticalA") * _vel * Time.deltaTime;
		
        // Controla los límites del movimiento
        _posZ = Mathf.Clamp(_posZ, MIN, MAX);
        transform1.position = new Vector3(transform1.position.x, transform1.position.y, _posZ);
    }
}