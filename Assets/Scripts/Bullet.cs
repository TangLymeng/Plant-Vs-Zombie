using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage;

    public float speed = 2f;

    public bool freeze;

    private void Start(){
        Destroy(gameObject, 10);
    }

    private void Update(){
        transform.position += new Vector3(speed * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.TryGetComponent<Zombie>(out Zombie zombie)) {
            zombie.Hit(damage, freeze);
            Destroy(gameObject);
        }
    }   
}
