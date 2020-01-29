using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cinematics : MonoBehaviour
{
    private float _posX;
    private float _minX;
    private float _posIniX;
    private float _maxX;
    private float _minZ;
    private float _maxZ;
    private float _posZ;
    private float _posIniZ;

    // Use this for initialiXation
    void Start()
    {
        _minZ = -2F;
        _maxZ = 14.43F;
        _minX = -16.6F;
        _maxX = 16.35F;
        _posIniX = transform.position.x;
        _posIniZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        _posX += Input.GetAxis("Mouse X") * Time.deltaTime * 30;
        _posX = Mathf.Clamp(_posX, _minX + _posIniX, _maxX + _posIniX);

        _posZ += Input.GetAxis("Mouse Y") * Time.deltaTime * 20;
        _posZ = Mathf.Clamp(_posZ, _minZ + _posIniZ, _maxZ + _posIniZ);

        transform.position = new Vector3(_posX, transform.position.y, _posZ);


        ResetPosition();
        GoMainMenu();
    }

    private void ResetPosition()
    {
        if (Input.GetKeyUp(KeyCode.R))
        {
            transform.SetPositionAndRotation(new Vector3(_posIniX, 0.5F, _posIniZ), Quaternion.identity);
            _posX = _posIniX;
            _posZ = _posIniZ;
        }
    }

    private void GoMainMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            SceneManager.LoadScene("Scenes/Menu");
    }
}