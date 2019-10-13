using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverCapsula : MonoBehaviour
{
    private const float MIN = -4;
    private const float MAX = 4;
    public float _posX = 0;
    public float _posY = 0.95188F;
    public float _posZ = 0;

    private float _vel = 3;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var transform1 = transform;
        _posX += Input.GetAxis("Horizontal") * _vel * Time.deltaTime;
        _posY += Input.GetAxis("Jump") * _vel * Time.deltaTime;
        _posZ += Input.GetAxis("Vertical") * _vel * Time.deltaTime;

        // Controla los límites del movimiento
        _posX = Mathf.Clamp(_posX, MIN, MAX);
        _posZ = Mathf.Clamp(_posZ, MIN, MAX);
        _posY = Mathf.Clamp(_posY, 0.95188F, MAX);
        transform1.position = new Vector3(_posX, _posY, _posZ);
    }
}