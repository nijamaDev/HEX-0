using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public Texture2D cursorTexture;
  Vector2 mousePosition;
  Vector2 direction;
  float angle;
  Vector3 targetRotation;
  public float turnSpeed = 45;
  public float moveSpeed = 25;
  Rigidbody2D rb;
  // Start is called before the first frame update
  void Start()
  {
    // Set custom cursor
    //Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
    rb = GetComponent<Rigidbody2D>();
  }

  // Update is called once per frame
  void Update()
  {
    // Get world position for the mouse
    mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    // Get the direction of the mouse relative to the player and rotate the player to said direction
    direction = mousePosition - (Vector2)transform.position;
    angle = Vector2.SignedAngle(Vector2.down, direction);
    // transform.eulerAngles = new Vector3(0, 0, angle);
    targetRotation = new Vector3(0, 0, angle);
    // rb.MoveRotation(Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(targetRotation), turnSpeed * Time.deltaTime));

    if (Input.GetKeyDown(KeyCode.Mouse0))
    {
      // Debug.Log("Fire!");
    }
    if (Input.GetKey(KeyCode.Mouse1))
    {
      rb.AddForce(-(Vector2)transform.up * moveSpeed * Time.deltaTime);
    }
  }
}
