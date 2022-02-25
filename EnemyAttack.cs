using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAtack : MonoBehaviour
{
    [SerializeField] Transform prefabBullet = null;
    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Shoot());
    }

    IEnumerator Shoot()
    {
        float timer = Random.Range(2f, 4f);
        yield return new WaitForSeconds(timer);
        Transform Bullet = Instantiate(prefabBullet, transform.position, Quaternion.identity);
        //Bullet.gameObject.GetComponent<Rigidbody2D>()
    }
}
