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
      return;
    }
    timer += Time.deltaTime;
    spawnTimer = 3.5f;

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
    bool approved = false;
    GameObject child;
    if (posX >= 4 || posX <= -4)
    {
      approved = true;
    }
    else if (posY >= 4 || posY <= -4)
    {
      approved = true;
    }
    if (approved)
    {
      Vector2 pos = new Vector2(posX, posY);
      Quaternion rot = new Quaternion();
      child = Instantiate(Enemy, pos, rot);
      child.transform.parent = gameObject.transform;
    }
  }
}
