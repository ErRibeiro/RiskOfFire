using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FasterAtkSpeed : MonoBehaviour
{
    [SerializeField]
    private GameObject Pistol;
    [SerializeField]
    private GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            float cd;
            cd = Pistol.GetComponent<Pistol>().coolDown;
            cd = cd * .9f;
            Pistol.GetComponent<Pistol>().coolDown = cd;
        }   
    }
}
