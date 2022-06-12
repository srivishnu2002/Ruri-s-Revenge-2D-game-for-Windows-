using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    public Transform firePointCrouch;
    public Transform firePointOrb;
    public GameObject bulletPrefab;
    public GameObject SuperOrb;
    
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            
            Shoot();
        }
        if (Input.GetButtonDown("Fire2"))
        {
            
            ShootCrouch();
        }

        if (Input.GetButtonDown("Fire3"))
        {
            
            ShootSuperOrb();
        }

    }
    public void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        SoundManagerScript.PlaySound("fire");
    }
    public void ShootCrouch()
    {
        Instantiate(bulletPrefab, firePointCrouch.position, firePoint.rotation);
        SoundManagerScript.PlaySound("fire");
    }
    public void ShootSuperOrb()
    {
        Instantiate(SuperOrb, firePointOrb.position, firePoint.rotation);
        SoundManagerScript.PlaySound("trueorb");
    }





}