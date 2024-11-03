using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Apu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CarregarCena());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator CarregarCena()
    {
        yield return new WaitForSeconds(3.5f);
        SceneManager.LoadScene("Scenes/Carregamento", LoadSceneMode.Single);
    }
}
