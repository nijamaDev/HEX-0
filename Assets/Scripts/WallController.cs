using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class WallController : MonoBehaviour
{
  int counter;
  string text = "";
  public TextMeshProUGUI multiplier;
  public Text puntos;
  private void OnTriggerEnter2D(Collider2D other)
  {
    //counter = int.Parse(
    Debug.Log(multiplier);
    //text = multiplier.text;
    //counter++;
    //text = counter.ToString();
    //multiplier.text = text;
    //puntos.text = int.Parse(puntos.text + counter).ToString();
    Destroy(other.gameObject);
  }
}
