using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolScript : MonoBehaviour
{
    [SerializeField]
    private GameObject BulletP;
    [SerializeField]
    private GameObject Weapon;
    private float cooldownTime;
    public float coolDown = 1;

    void Update()
    {
        BulletP.transform.position = Weapon.transform.position;
        BulletP.transform.rotation = Weapon.transform.rotation;
        if (cooldownTime > 0)
        {
            cooldownTime -= Time.deltaTime;
        }
        if (cooldownTime < 0)
        {
            cooldownTime = 0;
        }
        if (Input.GetMouseButton(0) && cooldownTime == 0)
        {
            Instantiate(BulletP);
           
            cooldownTime = coolDown;
        }
    }
}

    

   

