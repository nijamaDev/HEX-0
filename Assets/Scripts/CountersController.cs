using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountersController : MonoBehaviour
{
  public TMP_Text points;
  public TMP_Text multiplier;
  int mult;
  void Start()
  {
    multiplier = FindObjectOfType<TMP_Text>();
    multiplier = FindObjectOfType<TMP_Text>();
  }
  private void OnTriggerEnter2D(Collider2D col)
  {
    if (col.CompareTag("Enemy"))
    {
      mult = int.Parse(multiplier.text.Remove(0, 1)) + 1;
      multiplier.text = "X" + mult;
      Destroy(col.gameObject);
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


