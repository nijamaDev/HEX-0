using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WallController : MonoBehaviour
{
  //public TMP_Text multiplier;
  private void OnTriggerEnter2D(Collider2D col)
  {
    if (col.tag == "bullet")
    {
      //multiplier.text = "X0";
      Destroy(col.gameObject);
    }
  }
}
