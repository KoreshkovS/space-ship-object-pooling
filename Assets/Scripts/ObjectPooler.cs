using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class ObjectPooler : MonoBehaviour
{
    [SerializeField] private GameObject _pooledObject;
    [SerializeField] private int _pooledAmount;
    [SerializeField] private bool _willGrow;

    private List<GameObject> _pooledObjects;

    private void Start()
    {
        _pooledObjects = new List<GameObject>();
        for (int i = 0; i < _pooledAmount; i++)
        {
            GameObject obj = Instantiate(_pooledObject);
            obj.SetActive(false);
            _pooledObjects.Add(obj);
        }
    }

    public GameObject GetPooledObject()
    {
        for (int i = 0; i < _pooledObjects.Count; i++)
        {
            if (!_pooledObjects[i].activeInHierarchy)
            {
                return _pooledObjects[i];
            }
        }
        if (_willGrow)
        {
            GameObject obj = Instantiate(_pooledObject);
            _pooledObjects.Add(obj);
            return obj;
        }

        return null;
    }
}
