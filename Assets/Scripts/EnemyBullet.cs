using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
  [SerializeField] private float velocity;
  float timer = 0;
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    timer += Time.deltaTime;
    if (timer > 4)
    {
      Destroy(gameObject);
    }
    transform.Translate(Vector2.down * velocity * Time.deltaTime);
  }

  private void OnTriggerEnter2D(Collider2D other)
  {
    if (other.CompareTag("Player"))
    {
      Destroy(gameObject);
    }
  }
}
