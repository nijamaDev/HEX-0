using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerController : MonoBehaviour
{
  float timer;
  float spawnTimer;
  GameObject player;
  public GameObject runner;
  public GameObject shooter;

  void Start()
  {
    player = GameObject.Find("Player");
  }
  void Update()
  {
    if (player == null)
    {
      Destroy(gameObject);
    }
    timer += Time.deltaTime;
    spawnTimer = 2;

    if (timer > spawnTimer)
    {
      timer = 0;
      Spawn(runner);
      Spawn(shooter);
    }
  }
  void Spawn(GameObject Enemy)
  {
    float posX = Random.Range(-8, 8);
    float posY = Random.Range(-8, 8);

    if (posX >= 4 || posX <= -4)
    {
      Vector2 pos = new Vector2(posX, posY);
      Quaternion rot = new Quaternion();

      Instantiate(Enemy, pos, rot);

    }
    else if (posY >= 4 || posY <= -4)
    {
      Vector2 pos = new Vector2(posX, posY);
      Quaternion rot = new Quaternion();

      Instantiate(Enemy, pos, rot);
    }
  }
}
