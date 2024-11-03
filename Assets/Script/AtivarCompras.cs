using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AtivarCompras : MonoBehaviour
{
    GameObject jogador;
    public GameObject compras;
    inventario player;
    public Text txtMeuDinheiro;
    // Start is called before the first frame update


    void Awake()
    {
        jogador = GameObject.FindGameObjectWithTag("Player");
        player = jogador.GetComponent<inventario>();
    }
    // Update is called once per frame
    
    public void OnTriggerStay(Collider other)
    {
        inventario playerInvent = other.GetComponent<inventario>();
        txtMeuDinheiro.text=""+player.NrmDinheiro+"Coins";
        if (other.gameObject == jogador )
        {
           
            if (Input.GetKeyDown("f"))
            {
                compras.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }

}
