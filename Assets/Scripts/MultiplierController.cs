using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MultiplierController : MonoBehaviour
{
  public TMP_Text text;
  int mult;
  Rigidbody2D rb;

  void Start()
  {
    text = FindObjectOfType<TMP_Text>();
  }
  private void OnTriggerEnter2D(Collider2D col)
  {
    if (col.tag == "a")
    {

    }
    mult = int.Parse(text.text.Remove(0, 1)) + 1;
    text.text = "X" + mult;
    if (col.gameObject.name == "Square")
    {
      mult = mult + 1;
      text.text = "x" + mult;
      Destroy(col.gameObject);
    }

  }

  // public void Awake()
  // {
  //   rb = GetComponent<Rigidbody2D>();
  //   contador = 0;
  //   multiplier.text = "x" + contador;
  // }
}


