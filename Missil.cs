using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missil : MonoBehaviour
{
    public float speed;

    void Start()
    {
        Destroy(gameObject, 3);
    }


    // Update is called once per frame

    void Update()
    {
        Destroy(gameObject, 3);

        transform.position +=
        transform.forward *
        speed * Time.deltaTime;
    }
    void OnTriggerEnter(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        Destroy(enemy.gameObject);
    }
}
