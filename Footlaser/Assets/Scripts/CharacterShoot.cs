using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject _bulletPrefab;

    private float _fireRate = 0.5f;
    private float _nextFire = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
            Instantiate(_bulletPrefab, transform.position + new Vector3(.88f, 0, 0), Quaternion.identity);

            _nextFire = Time.time + _fireRate;
        }
    }
}
