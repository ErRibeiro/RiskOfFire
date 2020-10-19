using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FasterAtkSpeed : MonoBehaviour
{
    [SerializeField]
    private GameObject Pistol;
    private float pistolcd;
    private float buffamount = .9f;
    private void Start()
    {
        pistolcd = Pistol.GetComponent<PistolScript>().coolDown;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            buff();
            Destroy(this.gameObject);
        }   
    }
    private void buff()
    {
        pistolcd = pistolcd * .9f;
        Pistol.GetComponent<PistolScript>().coolDown = pistolcd;
    }
}
