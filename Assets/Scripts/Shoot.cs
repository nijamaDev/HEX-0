using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private Transform BulletController;
    [SerializeField] private GameObject Bullet;
    float timer;

    private void Update(){

        timer += Time.deltaTime;
        if(timer >= 3)
        {
            timer = 0;
            Instantiate(Bullet, BulletController.position, BulletController.rotation);
        }
    }



}
