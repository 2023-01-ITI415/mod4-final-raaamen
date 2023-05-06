using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public decimal totalCubes;

    public decimal healthAdd;

    public Slider healthSlider;

    public TextMeshProUGUI gameOverText;

    bool gameOver;

    private int health;
    
    private void Awake() {
        
    }
    
    void Start()
    {
        totalCubes = GameObject.FindGameObjectsWithTag("Collectible").Length;
        healthAdd = 1/totalCubes;
        
    }

    public void ChangeMeter(){
        healthSlider.value+=(float)healthAdd;
        if (healthSlider.value == 1)
        {
            GameOver();
        }
    }

    public void GameOver(){
        gameOverText.gameObject.SetActive(true);
    }

}
