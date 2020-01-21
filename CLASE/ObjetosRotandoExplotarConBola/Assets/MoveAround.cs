using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveAround : MonoBehaviour
{
    private const float _VEL = 10;
    private int _score = 0;
    public Text _Text;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxis("Vertical") * _VEL * Time.deltaTime, 0,
            Input.GetAxis("Horizontal") * _VEL * Time.deltaTime);

        // Debug.LogFormat(gameObject.GetComponent<Rigidbody>().GetPointVelocity(gameObject.transform.position).magnitude.ToString());

        Debug.Log(_score);
        _Text.GetComponent<Text>().text = "TU PUNTUACION DE SOPLAPOLLAS ES \n PUNTUACIÓN: " + _score;
        CheckEndGame();
    }

    private void CheckEndGame()
    {
        if (_score == 20)
            Time.timeScale = 0;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (gameObject.GetComponent<Rigidbody>().GetPointVelocity(gameObject.transform.position).magnitude >= 0.5F
            && other.gameObject.tag.Equals("Player"))
        {
            switch (other.gameObject.GetComponent<MeshFilter>().sharedMesh.name)
            {
                case "Cube":
                    _score += 4;
                    break;
                case "Capsule":
                    _score += 6;
                    break;
            }
            Destroy(other.gameObject, 0);
        }
    }
}