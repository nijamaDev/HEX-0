using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    float timer;
    public GameObject enemyPrefab;
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= 5)
        {
            timer = 0;
            float posXGenerator = Random.Range(-3.5f, 3.5f);
            float posYGenerator = Random.Range(-3.5f, 3.5f);
            Vector3 pos = new Vector3(posXGenerator, posYGenerator, 0);
            Quaternion rot = new Quaternion();

            Instantiate(enemyPrefab, pos, rot);
        }
    }
}
