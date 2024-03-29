using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRunner : MonoBehaviour
{
  public float turnSpeed;
  public float moveSpeed;
  Vector2 playerPosition;
  Vector2 direction;
  GameObject player;
  Rigidbody2D rb;
  float impulse;
  float angle;
  // Start is called before the first frame update
  void Start()
  {
    rb = GetComponent<Rigidbody2D>();
    player = GameObject.Find("Player");
  }
  void Update()
  {
    if (player == null)
    {
      return;
    }
    Move();
  }
  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.CompareTag("bullet"))
    {
      Destroy(gameObject);
    }
  }
  void Move()
  {
    playerPosition = player.transform.position;
    direction = playerPosition - (Vector2)transform.position;
    angle = Vector2.SignedAngle(-transform.up, direction);
    impulse = angle * Mathf.Deg2Rad * turnSpeed * rb.inertia;
    rb.AddTorque(impulse, ForceMode2D.Force);
    rb.AddForce(-(Vector2)transform.up * moveSpeed * Time.deltaTime);
  }
}
