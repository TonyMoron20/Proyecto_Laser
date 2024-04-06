using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float _speed;

    void Start()
    {
        _speed = Random.Range(3f, 6f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime);

        if(transform.position.x < -10)
        {
            Destroy(this.gameObject);
        }
    }
}
