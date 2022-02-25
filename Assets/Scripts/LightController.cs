using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class LightController : MonoBehaviour
{
  public Light2D lt1, lt2, lt3, lt4, lt5, lt6;
  private bool st1, st2, st3, st4, st5, st6;
  private float time;
  void Start()
  {
    st1 = true;
    st2 = false;
    st3 = false;
    st4 = false;
    st5 = false;
    st6 = false;
    time = 0;
  }
  /**
Red(255,0,0)
Magenta(255,0,255)
Blue(0,0,255)
cyan(0,255,255)
Green(0,255,0)
Yellow(255,255,0)
*/
  // Update is called once per frame
  void Update()
  {
    changeIntensity(lt1);
    changeIntensity(lt2);
    changeIntensity(lt3);
    changeIntensity(lt4);
    changeIntensity(lt5);
    changeIntensity(lt6);
    time += 0.5f * Time.deltaTime;
    if (time > 1) time = 1;
    if (st1) // stage1
    {
      lt1.color = Color.Lerp(Color.red, Color.magenta, time);
      lt2.color = Color.Lerp(Color.magenta, Color.blue, time);
      lt3.color = Color.Lerp(Color.blue, Color.cyan, time);
      lt4.color = Color.Lerp(Color.cyan, Color.green, time);
      lt5.color = Color.Lerp(Color.green, Color.yellow, time);
      lt6.color = Color.Lerp(Color.yellow, Color.red, time);
      if (lt1.color == Color.magenta)
      {
        st1 = false;
        st2 = true;
        time = 0;
      }
    }
    else if (st2)
    {
      lt1.color = Color.Lerp(Color.magenta, Color.blue, time);
      lt2.color = Color.Lerp(Color.blue, Color.cyan, time);
      lt3.color = Color.Lerp(Color.cyan, Color.green, time);
      lt4.color = Color.Lerp(Color.green, Color.yellow, time);
      lt5.color = Color.Lerp(Color.yellow, Color.red, time);
      lt6.color = Color.Lerp(Color.red, Color.magenta, time);
      if (lt1.color == Color.blue)
      {
        st2 = false;
        st3 = true;
        time = 0;
      }
    }
    else if (st3)
    {
      lt1.color = Color.Lerp(Color.blue, Color.cyan, time);
      lt2.color = Color.Lerp(Color.cyan, Color.green, time);
      lt3.color = Color.Lerp(Color.green, Color.yellow, time);
      lt4.color = Color.Lerp(Color.yellow, Color.red, time);
      lt5.color = Color.Lerp(Color.red, Color.magenta, time);
      lt6.color = Color.Lerp(Color.magenta, Color.blue, time);
      if (lt1.color == Color.cyan)
      {
        st3 = false;
        st4 = true;
        time = 0;
      }
    }
    else if (st4)
    {
      lt1.color = Color.Lerp(Color.cyan, Color.green, time);
      lt2.color = Color.Lerp(Color.green, Color.yellow, time);
      lt3.color = Color.Lerp(Color.yellow, Color.red, time);
      lt4.color = Color.Lerp(Color.red, Color.magenta, time);
      lt5.color = Color.Lerp(Color.magenta, Color.blue, time);
      lt6.color = Color.Lerp(Color.blue, Color.cyan, time);
      if (lt1.color == Color.green)
      {
        st4 = false;
        st5 = true;
        time = 0;
      }
    }
    else if (st5)
    {
      lt1.color = Color.Lerp(Color.green, Color.yellow, time);
      lt2.color = Color.Lerp(Color.yellow, Color.red, time);
      lt3.color = Color.Lerp(Color.red, Color.magenta, time);
      lt4.color = Color.Lerp(Color.magenta, Color.blue, time);
      lt5.color = Color.Lerp(Color.blue, Color.cyan, time);
      lt6.color = Color.Lerp(Color.cyan, Color.green, time);
      if (lt1.color == Color.yellow)
      {
        st5 = false;
        st6 = true;
        time = 0;
      }
    }
    else if (st6)
    {
      lt1.color = Color.Lerp(Color.yellow, Color.red, time);
      lt2.color = Color.Lerp(Color.red, Color.magenta, time);
      lt3.color = Color.Lerp(Color.magenta, Color.blue, time);
      lt4.color = Color.Lerp(Color.blue, Color.cyan, time);
      lt5.color = Color.Lerp(Color.cyan, Color.green, time);
      lt6.color = Color.Lerp(Color.green, Color.yellow, time);
      if (lt1.color == Color.red)
      {
        st6 = false;
        st1 = true;
        time = 0;
      }
    }
    void changeIntensity(Light2D lt)
    {
      lt.intensity = 0.4f + Mathf.PingPong(Time.time / 10, 0.2f);
    }

  }
}
