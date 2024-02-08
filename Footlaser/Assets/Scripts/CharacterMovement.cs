using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField]
    private float _speed = 6f;
    private float _amountFloating = 0;
    private float _maxFloating = 3;
    private bool _canFloat = true;

    //public GameObject prefabEnemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Space) && _canFloat)
        {
            if(_amountFloating < _maxFloating)
            {
                transform.Translate(Vector3.up * _speed * Time.deltaTime);
                _amountFloating += _speed * Time.deltaTime;
            }
            else
            {
                _canFloat = false;
            }
        }
        else
        {
            if (transform.position.y > -3)
            {
                transform.Translate(Vector3.down * _speed * Time.deltaTime);
                _amountFloating -= _speed * Time.deltaTime;
            }
            else if(transform.position.y <= -3) 
            {
                _canFloat = true; 
            }
        }

        //if(Input.anyKeyDown)
        //{
        //    Instantiate(prefabEnemy, new Vector3(10, -3, 0), Quaternion.identity);
        //}
    }
}
