using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;

    [SerializeField] private int _damage;
    [SerializeField] private float _speed;

    public float Speed => _speed;

    public Rigidbody2D Rigidbody => _rigidbody;

    private void Update()
    {
        _rigidbody.velocity = -transform.right * _speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent(out Enemy enemy))
        {
            enemy.TakeDamage(_damage);

            Destroy(gameObject);
        }
    }

    public void MoveBullet(Vector2 direction)
    {
        _rigidbody.velocity = direction * _speed;
    }
}
