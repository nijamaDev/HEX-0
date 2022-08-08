using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountersController : MonoBehaviour
{
  public TextMeshPro points;
  public TMP_Text multiplier;
  int addPoints;
  int mult;
  void Start()
  {
    points = GameObject.Find("Score").GetComponent<TextMeshPro>();
    multiplier = GameObject.Find("Multiplier").GetComponent<TMP_Text>();
    Debug.Log(multiplier.text);
    Debug.Log(points.text);
  }
  private void OnTriggerEnter2D(Collider2D col)
  {
    if (col.CompareTag("Enemy"))
    {
      mult = int.Parse(multiplier.text.Remove(0, 1));
      //addPoints = int.Parse(points.text) * mult;
      mult++;
      multiplier.text = "X" + mult;

      Destroy(col.gameObject);
      Destroy(gameObject);
    }
  }
}


