using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class MoverCapsula : MonoBehaviour
{
    private const float MIN_X = -11;
    private const float MAX_X = 20;
    private const float MIN_Y = -15.5F;
    private const float MAX_Y = 15.5F;
    public float _posX = 0;
    public float _posZ = 0;

    private float _vel = 8;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var transform1 = transform;
        _posZ += Input.GetAxis("Horizontal") * _vel * Time.deltaTime;
        _posX -= Input.GetAxis("Vertical") * _vel * Time.deltaTime;

        // Controla los límites del movimiento
        _posX = Mathf.Clamp(_posX, MIN_X, MAX_X);
        _posZ = Mathf.Clamp(_posZ, MIN_Y, MAX_Y);
        transform1.position = new Vector3(_posX, transform1.position.y, _posZ);
    }
}