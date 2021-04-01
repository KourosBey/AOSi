using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class palyer : MonoBehaviour
{
    public int olumSayaci;
    public int maxHealth = 100;
    public int currentHeealth;
    public healthbar healthbar;
    public SkillScript skillBar;
   
    // Start is called before the first frame update
    void Start()
    {
        
        olumSayaci = 0;
        currentHeealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth,0);
        
    }
   

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            
            TakeDamage(5);
            if (currentHeealth == 0)
            {
                olumSayaci +=1;
                currentHeealth = 100;
                Debug.Log( olumSayaci + "Kere öldün.");

            }
        }
        if(Input.GetKeyDown(KeyCode.Q))
        {
            skillBar.skillBasti();

        }
        

    }
    void TakeDamage(int damage)
    {
        currentHeealth -= damage;
        healthbar.SetHealth(currentHeealth);
    }
    
}
