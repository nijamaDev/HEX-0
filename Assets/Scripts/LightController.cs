using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightController : MonoBehaviour
{
  public Light2D lt1, lt2, lt3, lt4, lt5, lt6;
  private Light2D[] lts = new Light2D[6];
  /**
Red(255,0,0)
Magenta(255,0,255)
Blue(0,0,255)
cyan(0,255,255)
Green(0,255,0)
Yellow(255,255,0)
*/
  private Color[] colors = {
    Color.red,
    Color.magenta,
    Color.blue,
    Color.cyan,
    Color.green,
    Color.yellow,
    Color.red};
  private float time;
  private int stage;
  void Start()
  {
    lts[0] = lt1;
    lts[1] = lt2;
    lts[2] = lt3;
    lts[3] = lt4;
    lts[4] = lt5;
    lts[5] = lt6;
    time = 0;
    stage = 0;
  }

  // Update is called once per frame
  void Update()
  {
    time += 0.5f * Time.deltaTime;
    if (time > 1) time = 1;
    for (int i = 0; i < lts.Length; i++) // change the color of all the lights in the HEX
    {
      lts[i].color = Color.Lerp(colors[(stage + i) % 6], colors[1 + (stage + i) % 6], time);
      lts[i].intensity = 0.4f + Mathf.PingPong(Time.time / 10, 0.2f);
    }
    if (lt1.color == colors[stage + 1]) // if the color reaches the next stage, continue to next stage
    {
      stage++;
      time = 0;
    }
    if (stage > 5) stage = 0;

  }
}
