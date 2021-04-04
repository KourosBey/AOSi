using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hasarveiyilesme : MonoBehaviour
{
    int damage;
    int heal;
    int health;
    public healthbar hpbar;
    

    void Start()
    {
        health = 100;
        damage = 10;
        heal = 10;
        hpbar.GetComponent<healthbar>().SetMaxHealth(health,0);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Hasar();

        }
        if(Input.GetKeyDown(KeyCode.B))
        {
            iyilesme();
        }
    }

    void Hasar()
    {
         
        if(health<=0)
        {
            Debug.Log("Öldün çık");
        }
        else
           {
            health = health - damage;

            hpbar.GetComponent<healthbar>().SetHealth(health);


        }


    }
    void iyilesme()
    {

        if(health<100 && health>0)
        {
            health = health + heal;

            hpbar.GetComponent<healthbar>().SetHealth(health);

        }
        else
        {
            Debug.Log(health);
        }


    }
    
}
