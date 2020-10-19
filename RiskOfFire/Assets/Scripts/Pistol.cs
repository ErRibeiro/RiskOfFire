using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour
{
    [SerializeField]
    private GameObject BulletP;
    [SerializeField]
    public float cooldownTime;
    public float coolDown = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
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
            GameObject bullet = Instantiate(BulletP);
           
            cooldownTime = coolDown;
        }
    }
}

    

   

