using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private float _speed = 4.0f;

    void Update()
    {
        transform.Translate(Vector3.right * _speed * Time.deltaTime);
    }

    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals("Enemy"))
        {
            Destroy(collision);
            Destroy(this.gameObject);
        }
    }
}
