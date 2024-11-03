using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CristalCura : MonoBehaviour
{
    GameObject jogador;
    
    void Awake()
    {
        jogador = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTriggerEnter(Collider outro)
    {
       
        inventario playerInvent = outro.GetComponent<inventario>();
        if (outro.gameObject == jogador)
        {
            playerInvent.CristalCollect();
            gameObject.SetActive(false);
            
        }
    }


}
