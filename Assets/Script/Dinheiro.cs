using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dinheiro : MonoBehaviour
{
    GameObject jogador;

    void Awake()
    {
        jogador = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTriggerEnter(Collider other)
    {
        inventario playerInvent = other.GetComponent<inventario>();
        if (other.gameObject == jogador)
        {
            playerInvent.DinheiroCollect();
            
            Destroy(gameObject);
        }
    }
}
