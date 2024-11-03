using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoverCristal : MonoBehaviour
{
    GameObject jogador;
    public GameObject cura_1;
    public GameObject cura_2;
    public GameObject cura_3;
    public GameObject cura_4;
    public GameObject cura_5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Awake()
    {
        jogador = GameObject.FindGameObjectWithTag("Player");
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == jogador)
        {
            inventario playerInvent = other.GetComponent<inventario>();
            playerInvent.CristalRemove();
            

        }
    }
}
