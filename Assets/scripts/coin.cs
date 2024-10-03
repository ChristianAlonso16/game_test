using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public AudioSource moneda;
    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Ganaste moneda");
            moneda.PlayOneShot(moneda.clip);
            Destroy(this.gameObject);
        }
    }
}
