using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    
    public GameObject mascara;
    bool ativarMask;
    public GameObject ftmascara;
    private void Update()
    {
        if (Input.GetKey(KeyCode.M))
        {
            ativarMask = !ativarMask;
            if (ativarMask == true)
            {
                ftmascara.SetActive(false);
                mascara.SetActive(false);
            }
            else 
            {
                ftmascara.SetActive(true);
                mascara.SetActive(true);
            }


        }
    }
   

}
