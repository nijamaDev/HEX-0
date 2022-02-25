using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class count : MonoBehaviour
{
  int contador;
  public Text puntos;
  Rigidbody2D rb;
  private void OnTriggerEnter2D(Collider2D other)
  {
    contador = contador + 1;
    puntos.text = "" + contador;
    Destroy(other.gameObject);
  }

  public void Awake()
  {
    rb = GetComponent<Rigidbody2D>();
    contador = 0;
    puntos.text = "" + contador;
  }

}
