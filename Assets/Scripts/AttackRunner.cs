using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AttackRunner : MonoBehaviour
{
  public Texture2D cursorTexture;
  Vector2 playerPosition;
  Vector2 direction;
  float angle;
  float impulse;
  public float turnSpeed;
  public float moveSpeed;
  Rigidbody2D rb;
  private GameObject player;
  public TMP_Text multiplier;
  // Start is called before the first frame update
  void Start()
  {
    // Set custom cursor
    //Cursor.SetCursor(cursorTexture, Vector2.zero, CursorMode.Auto);
    rb = GetComponent<Rigidbody2D>();
    player = GameObject.Find("Player");
    multiplier = GameObject.Find("Multiplier").GetComponent<TMP_Text>();
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
  private void OnTriggerEnter2D(Collider2D col)
  {
    if (col.tag == "bullet")
    {
      //string aux = multiplier.text + "";
      //float nAux = int.Parse(aux);
      string aux = multiplier.text.ToString();
      int nAux = int.Parse(aux);
      Debug.Log(nAux);
      //string aux = (int.Parse(multiplier.GetParsedText() + 1)).ToString();
      //multiplier.text = aux;
      Destroy(col.gameObject);
    }

  }

}
