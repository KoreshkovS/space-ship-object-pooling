using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rb;

    void Update()
    {
        _rb.velocity = new Vector2(_rb.velocity.x, (_rb.velocity.y + _speed) * Time.deltaTime);
    }
}
