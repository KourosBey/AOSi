using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillScript : MonoBehaviour
{
    public GameObject skillq;
    public Image resim;

    public Sprite deneme;
    public bool isCooldown = false;
    int time = 500;
    
    // Start is called before the first frame update
    public void skillBasti()

    {
        



        if (isCooldown)
        {
            Debug.Log("Casting Failed." );
        }
        else
        {
            
            
            Debug.Log("Casting Succesfull.");
            isCooldown = true;
           

        }

     


    }
    private void FixedUpdate()
    {
        

        if (isCooldown)
        {

            if (time == 0)
            {
                Debug.Log("Cd bitti");
                time = 500;
                isCooldown = false;
            }
            else
            {
                
                time--;
                Debug.Log(time);
            }
                
            
        }

    }
}
