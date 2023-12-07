using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    //Variables 
    public int maxHealth;  
    public int currentHealth;   

    public GameObject h1; 
    public GameObject h2; 

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 2;
        currentHealth = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        currentHealth -= amount; //if you get hit, health lowers

        if (currentHealth == 2)
        {
            h2.SetActive(false);        //game object is removed from scene 
        }

        if (currentHealth == 1)
        {
            h1.SetActive(false);        //game object is removed from the scene 
        }

        if (currentHealth <= 0) //if health equals 0 
        {
            SceneManager.LoadScene("GameOver");         //go to GameOver scene 
        }
    }
}
