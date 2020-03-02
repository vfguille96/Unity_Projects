using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearEnemigos : MonoBehaviour
{
    public GameObject enemigo1;
    public GameObject enemigo2;
    public GameObject enemigo3;
    private GameObject _enemigoCopia;
    private bool respawn;

    // Use this for initialization
    void Start()
    {
        respawn = false;
        StartCoroutine(Esperar());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator Esperar()
    {
        while (!respawn)
        {
            respawn = true;
            switch (GameController.NIVEL_ACTUAL)
            {
                case 1:
                    _enemigoCopia = Instantiate(enemigo1, new Vector3(transform.position.x + 1000, transform.position.y + Random.Range(-400, 400), transform.position.z), Quaternion.identity,
                        GameObject.FindWithTag("Enemy1").transform);
                    break;
                case 2:
                    _enemigoCopia = Instantiate(enemigo2, new Vector3(transform.position.x + 1000, transform.position.y + Random.Range(-400, 400), transform.position.z), Quaternion.identity,
                        GameObject.FindWithTag("Enemy2").transform);
                    break;
                case 3:
                    _enemigoCopia = Instantiate(enemigo3, new Vector3(transform.position.x + 1000, transform.position.y + Random.Range(-400, 400), transform.position.z), new Quaternion(0, 0, 180, 0),
                        GameObject.FindWithTag("Enemy3").transform);
                    break;
                default:
                    _enemigoCopia = Instantiate(enemigo1, new Vector3(transform.position.x + 1000, transform.position.y + Random.Range(-400, 400), transform.position.z), Quaternion.identity,
                        GameObject.FindWithTag("Enemy1").transform);
                    break;
                
            }
            _enemigoCopia.GetComponent<Rigidbody2D>().AddForce(Vector2.left * GameController.VEL_ACTUAL, ForceMode2D.Impulse);
            Destroy(_enemigoCopia, 10);
            
            yield return new WaitForSeconds(3F);
            respawn = false;
        }
    }
}