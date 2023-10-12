using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{
    public Transform cactus1;
    public Transform cactus2;
    Animator animator1;
    Animator animator2;
    
    void Start()
    {
        animator1 = cactus1.GetComponent<Animator>();
        animator2 = cactus2.GetComponent<Animator>();
    }


    void Update()
    {
        float distance = Vector3.Distance(cactus1.position, cactus2.position);
        Debug.Log("distanta " + distance);
        if (distance < 0.25f)
        {
            animator1.SetBool("isAttacking", true);
            animator2.SetBool("isAttacking", true);
    
        }
        else
        {
            animator1.SetBool("isAttacking", false);
            animator2.SetBool("isAttacking", false);
        
        }
    }
}
