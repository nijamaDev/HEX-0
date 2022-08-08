using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameRestart : MonoBehaviour
{
  GameObject player;
  Text points;
  TMP_Text multiplier;
  void Start()
  {
    player = GameObject.Find("Player");
    points = GameObject.Find("Score").GetComponent<Text>();
    multiplier = GameObject.Find("Multiplier").GetComponent<TMP_Text>();
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyUp(KeyCode.R))
    {
      Restart();
    }
  }
  void Restart()
  {
    points.text = "0";
    multiplier.text = "X0";
    foreach (Transform child in transform)
    {
      GameObject.Destroy(child.gameObject);
    }
    player.SetActive(true);
    player.transform.position = new Vector2(0, 0);
  }
}
