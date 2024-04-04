using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    private UIManager _uiManager;
    public GameObject particlesPrefab;

    private void Start()
    {
        _uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag.Equals("Bullet"))
        {
            _uiManager.UpdateScore();
        }
        else if(collision.tag.Equals("Player"))
        {
            _uiManager.UpdateLifes(-1);
        }

        Instantiate(particlesPrefab, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
    }
}
