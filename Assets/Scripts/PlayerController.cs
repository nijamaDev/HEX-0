using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  public Texture2D cursorTexture;
  Vector3 mousePosition;
  Vector2 direction;
  float angle;
  // Start is called before the first frame update
  void Start()
  {
    // Set custom cursor
    //Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
  }

  // Update is called once per frame
  void Update()
  {
    // Get world position for the mouse
    mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    // Get the direction of the mouse relative to the player and rotate the player to said direction
    direction = mousePosition - transform.position;
    angle = Vector2.SignedAngle(Vector2.down, direction);
    transform.eulerAngles = new Vector3(0, 0, angle);
    // Debug.Log("Mouse Position: " + mousePosition);
    if (Input.GetKeyDown(KeyCode.Mouse0))
    {
      // Debug.Log("Fire!");
    }
    if (Input.GetKeyDown(KeyCode.Mouse1))
    {
      Debug.Log("Move!");
    }
  }
}
