using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   


    public Animator anim;

    // Start is called before the first frame update
    //Will be called once
    void Start()
    {
        
    }

    public void myFunction()
    {

    }


   // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Jump");

        }
    }
   

}//EndClass
