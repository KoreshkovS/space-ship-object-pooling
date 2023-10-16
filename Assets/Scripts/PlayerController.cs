using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rb;

    void Update()
    {
        _rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * _speed, _rb.velocity.y);
    }
}
