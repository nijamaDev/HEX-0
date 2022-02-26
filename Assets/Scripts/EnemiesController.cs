using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesController : MonoBehaviour
{
    private AudioSource destroySound;

    void Start(){
    }
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("bullet")){
            Destroy(gameObject);
        }
    }

}
