using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaJogador : MonoBehaviour
{
    // Start is called before the first frame update
    public int startingHealth = 100;
    public int currentHealth;

    //vida da mascara
    public int startingMask = 200;
    public int currentMask;


    public Slider healthSlider;
    public Slider MaskSlider;

    public Image damageImage;
    public float flashSpeed=5f;
    public Color flashColour = new Color(1f,0f,0f,0.1f);
    bool isDead=false;
    bool damage=false;
    public void TakeDamage(int amount)
    {
        damage = true;

        currentHealth -= amount;
        currentMask -=amount;
        
        healthSlider.value = currentHealth;
        MaskSlider.value = currentMask;
        //som de danos
        if (currentHealth<=0 && !isDead )
        {
            //animação de morte
        }
    }
    private void Awake()
    {
        currentHealth = startingHealth;
        currentMask = startingMask;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (damage)
        {
            damageImage.color = flashColour;
        }
        else
        {
            damageImage.color = Color.Lerp(damageImage.color,Color.clear, flashSpeed*Time.deltaTime);
        }
        damage = false;
    }
}
