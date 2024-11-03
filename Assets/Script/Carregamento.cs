using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Carregamento : MonoBehaviour
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
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene("Scenes/Menu", LoadSceneMode.Single);
    }
}
