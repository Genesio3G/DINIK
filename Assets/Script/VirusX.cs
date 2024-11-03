using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VirusX : MonoBehaviour
{
    public float tempodeatack = 0.5f;
    public int attackdamage = 10;

    GameObject jogador;
    VidaJogador playerHealth;
    public GameObject escudo;

    bool playerInRange=false;
    float timer;

    public GameObject msg;
    GameOver gameOver;

   
   
    // Start is called before the first frame update
    void Start()
    {
      
    }
     void Awake()
    {
        jogador = GameObject.FindGameObjectWithTag("Player");
        playerHealth = jogador.GetComponent<VidaJogador>();
        gameOver = msg.GetComponent<GameOver>();

       
      
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == jogador)
        {
            playerInRange = true;
         
            
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == jogador)
        {
            playerInRange = false;
        }
    }
    void ataque()
    {
        timer = 0f;/*
        if (playerHealth.currentMask>=0)
        {
            playerHealth.TakeDamage(1);
        }
        else
        {
            playerHealth.TakeDamage(attackdamage);
        }
        */
        if (playerHealth.currentHealth>=0)
        {
            if (escudo.activeSelf == true)
            {
                playerHealth.TakeDamage(1);
            }
            else { playerHealth.TakeDamage(attackdamage); }
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
        timer += Time.deltaTime;
        if (timer>=tempodeatack && playerInRange)
        {
            ataque();
        }
        if (playerHealth.currentHealth<=0)
        {
            //animacao do player morto
            gameOver.msgMP.text = "Morreste pelo virus";

        }


    }

}
