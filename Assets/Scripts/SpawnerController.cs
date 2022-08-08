using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
  float timer;
  float spawnTimer;
  public GameObject runner;
  public GameObject shooter;


  void Update()
  {
    timer += Time.deltaTime;
    spawnTimer = 2;

    if (timer > spawnTimer)
    {
      timer = 0;
      float posX = Random.Range(-8, 8);
      float posY = Random.Range(-8, 8);

      if (posX >= 4 || posX <= -4)
      {
        Vector2 pos = new Vector2(posX, posY);
        Quaternion rot = new Quaternion();

        Instantiate(runner, pos, rot);

      }
      else if (posY >= 4 || posY <= -4)
      {
        Vector2 pos = new Vector2(posX, posY);
        Quaternion rot = new Quaternion();

        Instantiate(runner, pos, rot);
      }
    }
  }
}
