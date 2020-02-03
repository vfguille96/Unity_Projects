using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radar : MonoBehaviour
{
    public GameObject[] TrackedObjects;
    private List<GameObject> _radarObjects;
    public GameObject _radarPrefab;
    private List<GameObject> _borderObjects;
    public float _swDistance;
    public Transform _helpTransform;


    // Use this for initialization
    void Start()
    {
        CreateRadarObjects();
    }

    void Update()
    {
        for (int i = 0; i < _radarObjects.Count - 1; i++)
        {
            if (Vector3.Distance(_radarObjects[i].transform.position, transform.position) > _swDistance)
            {
                _helpTransform.LookAt(_radarObjects[i].transform);
                _borderObjects[i].transform.position = transform.position + _swDistance * _helpTransform.forward;
                _borderObjects[i].layer = LayerMask.NameToLayer("Radar");
                _radarObjects[i].layer = LayerMask.NameToLayer("Invisible");
            }
            else
            {
                _borderObjects[i].layer = LayerMask.NameToLayer("Invisible");
                _radarObjects[i].layer = LayerMask.NameToLayer("Radar");
            }
        }
    }

    private void CreateRadarObjects()
    {
        _radarObjects = new List<GameObject>();
        _borderObjects = new List<GameObject>();
        foreach (GameObject gameObject in TrackedObjects)
        {
            GameObject _myGameObject = Instantiate(_radarPrefab, 
                new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 1, gameObject.transform.position.z), Quaternion.identity);
            _radarObjects.Add(_myGameObject);
            GameObject _myGameObject2 = Instantiate(_radarPrefab, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - 1, gameObject.transform.position.z), Quaternion.identity);
            _borderObjects.Add(_myGameObject2);
        }
    }

    // Update is called once per frame
}