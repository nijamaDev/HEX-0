using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerRunner : MonoBehaviour
{
    float timer;
    public GameObject enemyPrefab;

    
    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= 1)
        {
            timer = 0;
            float posXGenerator = Random.Range(-8, 8);
            float posYGenerator = Random.Range(-8, 8);

            if(posXGenerator >= 4 || posXGenerator <= -4){
                Vector3 pos = new Vector3(posXGenerator, posYGenerator, 0);
                Quaternion rot = new Quaternion();

                Instantiate(enemyPrefab, pos, rot);

            } else if(posYGenerator >= 4 || posYGenerator <= -4){
                Vector3 pos = new Vector3(posXGenerator, posYGenerator, 0);
                Quaternion rot = new Quaternion();

                Instantiate(enemyPrefab, pos, rot);
            }
        }
    }
}
