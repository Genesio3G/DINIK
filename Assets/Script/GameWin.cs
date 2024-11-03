using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameWin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void setup()
    {
        gameObject.SetActive(true);
    }
    public void RestartButton()
    {
        SceneManager.LoadScene("Scenes/Desafio", LoadSceneMode.Single);

    }
    public void homeButton()
    {
        SceneManager.LoadScene("Scenes/Menu", LoadSceneMode.Single);
    }
  
}
