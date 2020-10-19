using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float speed = 5;
    [SerializeField]
    private GameObject player;

    private float BulletLife = 10;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        player.transform.rotation = this.gameObject.transform.rotation;
        
        transform.position += transform.forward * speed * Time.deltaTime;
        BulletLife -= Time.deltaTime;
        if (BulletLife <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
