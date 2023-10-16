using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    [SerializeField] private static ObjectPooler _current;
    [SerializeField] private GameObject _pooledObject;
    [SerializeField] private int _pooledAmount;
    [SerializeField] private bool _willGrow;

    private List<GameObject> _pooledObjects;

    private void Start()
    {
        _current = this;
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

        }

        return null;
    }
}
