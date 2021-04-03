using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hasarveiyilesme : MonoBehaviour
{
    int damage;
    int heal;
    int health;


    void Start()
    {
        health = 100;
        damage = 10;
        heal = 10;

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
        health = health - damage;
        if(health<=0)
        {
            Debug.Log("Öldün çık");
        }
        else
           {
            Debug.Log(health);
         

        }


    }
    void iyilesme()
    {

        if(health<100 && health>0)
        {
            health = health + heal;
            Debug.Log("İyileştin"+ health);

        }
        else
        {
            Debug.Log(health);
        }


    }
    
}
