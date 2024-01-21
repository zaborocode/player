using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int healtf = 10;
    public GameObject fireballPrefab;
    public Transform attackPoint;
    // Start is called before the first frame update
    public void TakeDamage(int damage)
    {
        healtf -= damage;
        print("здоровье: " + healtf);

    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab,
      attackPoint.
      position, attackPoint.
      rotation);
        }
    }
}   





