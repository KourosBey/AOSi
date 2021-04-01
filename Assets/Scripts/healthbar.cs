using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{

    public Slider slider;
    public void SetMaxHealth(int health,int minHealth)
    {
       
        slider.maxValue = health;
        slider.value = health;
        slider.minValue = minHealth;
    }
    public void SetHealth(int health)
    {
        slider.value = health;
     

    }
 
}
