using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
{
  public float turnSpeed;
  public float moveSpeed;
  Vector2 playerPosition;
  Vector2 direction;
  float angle;
  float impulse;
  Rigidbody2D rb;
  private GameObject player;
  // Start is called before the first frame update
  void Start()
  {
    // Set custom cursor
    //Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
    rb = GetComponent<Rigidbody2D>();
    player = GameObject.Find("Player");
  }

  // Update is called once per frame
  void Update()
  {
    // Get world position for the mouse
    playerPosition = player.transform.position;
    // Get the direction of the mouse relative to the player and rotate the player to said direction
    direction = playerPosition - (Vector2)transform.position;
    angle = Vector2.SignedAngle(-transform.up, direction);
    impulse = angle * Mathf.Deg2Rad * turnSpeed * rb.inertia;
    rb.AddTorque(impulse, ForceMode2D.Force);

    rb.AddForce(-(Vector2)transform.up * moveSpeed * Time.deltaTime);
  }
  private void OnTriggerEnter2D(Collider2D collision)
  {
    if (collision.CompareTag("bullet"))
    {
      Destroy(gameObject);
    }
  }
}
