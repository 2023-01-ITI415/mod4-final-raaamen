using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{

    public Slider healthSlider;

    bool gameOver;

    private int _health;
    public int Health{
        get{
            return _health;
        }
        set{
            _health = value;
            if (_health <= 0)
            {
                
            }
        }
    }
    private void Awake() {
        
    }
    
    void Start()
    {
        
    }


    void Update()
    {
        
    }
}
