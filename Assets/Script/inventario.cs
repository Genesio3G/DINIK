using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class inventario : MonoBehaviour
{
   
    public Text INFmoney;
    public Text INFcura; 
    public GameObject win;
    public int NrmDinheiro { get;  set; }
    public int NrmCristal { get; private set; }

    public void Update()
    {
        INFmoney.text = "" + NrmDinheiro + "KZ";
    }
    public void DinheiroCollect()
    {

        NrmDinheiro=NrmDinheiro+50;
        INFmoney.text = ""+NrmDinheiro+"KZ";
    }
    public void CristalCollect()
    {
        
        NrmCristal++;
        INFcura.text = "" + NrmCristal;
        if (NrmCristal==5)
        {
            
            win.SetActive(true);
            NrmCristal = 5;
            Time.timeScale = 0;
        }
    }
    // Função que permite sair um cristal
    public void CristalRemove()
    {
        NrmCristal--;
          }


    
   
}
