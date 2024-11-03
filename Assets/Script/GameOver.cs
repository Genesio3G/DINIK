using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameOver : MonoBehaviour
{
    public VidaJogador playerHealth;
    public GameObject fundo;
    public GameObject panel;
    public Text msgMP;
    
    
   


    public void setup()
    {
        gameObject.SetActive(true);
    }
    private void Start()
    {
        Time.timeScale = 1;
       
      
    }
    public void RestartButton()
    {
        SceneManager.LoadScene("Scenes/Desafio", LoadSceneMode.Single);
        
    }
    public void homeButton()
    {
        SceneManager.LoadScene("Scenes/Menu",LoadSceneMode.Single);
    }
   
    private void Update()
    {
        if (playerHealth.currentHealth<=0)
        {
            //setar a animacao de morrer
            Time.timeScale = 0;
            fundo.SetActive(true);
            panel.SetActive(false);
            //msgMP.text;
        }
    }
}
