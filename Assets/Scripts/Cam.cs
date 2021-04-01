using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{

    public Transform target;
    public Vector3 offset;
    [Range(0, 1)]
    public float Smoothness;

    public bool CreateDeadzone;
    public float verticalLimit;
    public float horizontalLimit;
    private Vector3 positionAlign;

    public bool drawDebugLines;

    void Start()
    {
        positionAlign = target.position;
    }
   void FixedUpdate()
    {
        /*
        transform.position = target.position + offset;
        Vector3 smootheredFolow = Vector3.Lerp(transform.position, target.position, Smoothness);*/
        
        if (CreateDeadzone)
        {
            if(target.position.x < transform.position.x - verticalLimit || target.position.x > transform.position.x + verticalLimit || target.position.y < transform.position.y - horizontalLimit || target.position.y > transform.position.y + horizontalLimit)
            {
                positionAlign = target.position;
                
            }

            transform.position = Vector3.Lerp(transform.position, positionAlign + offset,Smoothness);
           /*
            transform.position = new Vector3(

                Mathf.Clamp(transform.position.x, transform.position.x - verticalLimit, transform.position.x + verticalLimit),
                Mathf.Clamp(transform.position.y, transform.position.y - horizontalLimit, transform.position.y + horizontalLimit),
                transform.position.z
                );*/
        }
        else
        {
            
            transform.position = Vector3.Lerp(transform.position, target.position + offset, Smoothness);
        }
    }


    private void OnDrawGizmos()
    {
        if (drawDebugLines)
        {
            Gizmos.color = Color.red;
            Gizmos.DrawLine(new Vector2(transform.position.x - verticalLimit, transform.position.y + horizontalLimit), new Vector2(transform.position.x + verticalLimit, transform.position.y + horizontalLimit));
            Gizmos.DrawLine(new Vector2(transform.position.x - verticalLimit, transform.position.y - horizontalLimit), new Vector2(transform.position.x + verticalLimit, transform.position.y - horizontalLimit));
            Gizmos.DrawLine(new Vector2(transform.position.x + verticalLimit, transform.position.y - horizontalLimit), new Vector2(transform.position.x + verticalLimit, transform.position.y + horizontalLimit));
            Gizmos.DrawLine(new Vector2(transform.position.x - verticalLimit, transform.position.y - horizontalLimit), new Vector2(transform.position.x - verticalLimit, transform.position.y + horizontalLimit));
        }
       
    }
}
