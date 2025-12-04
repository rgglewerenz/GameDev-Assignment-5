using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private int ammo = 10;

    public Transform firepoint;
    public GameObject bulletPrefab;

    public void Shoot()
    {
        if (ammo <= 0)
        {
            Debug.Log("Out of ammo!");
            return;
        }
        ammo--;
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }
}
