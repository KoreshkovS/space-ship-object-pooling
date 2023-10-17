using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private float _disableTime;

    private void Start()
    {
        BulletMoving();
    }

    private void OnEnable()
    {
        if (_rb != null)
        {
            BulletMoving();
        }

        Invoke("Disable", _disableTime);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }

    private void BulletMoving()
    {
        _rb.velocity = Vector2.up * _speed;
    }

    private void Disable()
    {
        gameObject.SetActive(false);
    }
}
