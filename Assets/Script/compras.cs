using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class compras : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Maskplayer;
    inventario player;
    GameObject Jogador;
    public GameObject bancada;
    private int mascara ;
    

    void Start()
    {

    }
    private void Awake()
    {
        Jogador = GameObject.FindGameObjectWithTag("Player");
        player = Jogador.GetComponent<inventario>();
    }
    // Update is called once per frame

    void Update()
    {
        inventario playerInvent = GetComponent<inventario>();
    }

    public void Mascara100()
    {
       mascara = 100;
        if (player.NrmDinheiro>=mascara)
        {
       
            player.NrmDinheiro -= 100;
            Maskplayer.SetActive(true);
            Time.timeScale = 1;
            bancada.SetActive(false);
        }
        else
        {
            bancada.SetActive(false);
            Time.timeScale = 1;
        }

            }
}
