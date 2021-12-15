using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GladiatorCollision : MonoBehaviour
{
    float life = 2;
    int iframe = 500;
    bool invincible = false;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("PlayerWeapon") && invincible == false)
        {
            life -= 1;
            iframe = 0;
            invincible = true;
        }
    }

    void FixedUpdate()
    {
        if (life <= 0)
            Destroy(gameObject);
        iframe += 1;
        if (iframe >= 100)
            invincible = false;
    }
}
