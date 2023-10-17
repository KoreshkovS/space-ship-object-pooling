using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rb;

    [Header("Shooting")]
    [SerializeField] private Transform _firePosition;
    [SerializeField] private ObjectPooler _objectPooler;


    void Update()
    {
        _rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * _speed, _rb.velocity.y);

        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }

    private void Fire()
    {
        GameObject obj = _objectPooler.GetPooledObject();

        if (obj == null)
        {
            return;
        }

        obj.transform.position = _firePosition.position;
        obj.transform.rotation = _firePosition.rotation;
        obj.SetActive(true);
    }
}
