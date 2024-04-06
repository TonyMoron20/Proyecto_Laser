using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject _bulletPrefab;

    private float _fireRate = 0.5f;
    private float _nextFire = 0.0f;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        if (Time.time > _nextFire)
        {
            Instantiate(_bulletPrefab, transform.position + new Vector3(.88f, .2f, 0), Quaternion.identity);

            _nextFire = Time.time + _fireRate;
        }
    }
}
