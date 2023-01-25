using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class healthygrl : MonoBehaviour
{
    public Slider healthSlider;
    public float fullHealth;

    float currentHealth;
    playerController controlMovement;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = fullHealth;

        controlMovement = GetComponent<playerController>();
        healthSlider.maxValue = fullHealth;
        healthSlider.value = fullHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addDamage(float damage)
    {
        if (damage <= 0) return;
        currentHealth -= damage;
        healthSlider.value = currentHealth;
        if (currentHealth <= 0)
        {
            makeDead();
        }
    }
        public void makeDead()
        {
        SceneManager.LoadScene("GameOver");
        }
    


}
