using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class countM : MonoBehaviour
{
  public TMP_Text multiplier;
  int contador;
  Rigidbody2D rb;


  private void OnTriggerEnter2D(Collider2D collider)
  {
    GameObject objeto1 = GameObject.Find("bullet");
    if (collider.gameObject.name == "Square")
    {
      contador = contador + 1;
      multiplier.text = "x" + contador;
      Destroy(collider.gameObject);
    }
    else
    {
      contador = 0;
    }

    if (collider.CompareTag("Enemy"))
    {
      Destroy(gameObject);
    }
  }

  // public void Awake()
  // {
  //   rb = GetComponent<Rigidbody2D>();
  //   contador = 0;
  //   multiplier.text = "x" + contador;
  // }
}


