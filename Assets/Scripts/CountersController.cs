using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CountersController : MonoBehaviour
{
  Text points;
  TMP_Text multiplier;
  int addPoints;
  int mult;
  void Start()
  {
    points = GameObject.Find("Score").GetComponent<Text>();
    multiplier = GameObject.Find("Multiplier").GetComponent<TMP_Text>();
  }
  private void OnTriggerEnter2D(Collider2D col)
  {
    if (col.CompareTag("Enemy"))
    {
      mult = int.Parse(multiplier.text.Remove(0, 1));
      addPoints = int.Parse(points.text) + mult + 1;
      points.text = addPoints.ToString();
      mult++;
      multiplier.text = "X" + mult;

      Destroy(col.gameObject);
      Destroy(gameObject);
    }
  }
}


