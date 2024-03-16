using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject flyingEnemyPrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemySpawnRoutine());
    }

    private IEnumerator EnemySpawnRoutine()
    {
        while (true)
        {
            Instantiate(enemyPrefab, new Vector3(10, -3, 0), Quaternion.identity);
            Instantiate(flyingEnemyPrefab, new Vector3(10f, RandomHeight(), 0f), Quaternion.identity);
            yield return new WaitForSeconds(2.0f);
        }
    }

    private float RandomHeight()
    {
        return Random.Range(0, 2);
    }
}
