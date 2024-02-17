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
            Instantiate(particlesPrefab, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
