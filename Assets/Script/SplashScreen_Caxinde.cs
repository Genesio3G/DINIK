using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SplashScreen_Caxinde : MonoBehaviour
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
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Scenes/Apu", LoadSceneMode.Single);
    }
}
