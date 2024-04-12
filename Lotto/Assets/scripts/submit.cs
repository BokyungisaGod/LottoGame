using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class submit : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator anim;
    public Animator basket;
    public Animator fadeout;
    public Animator close;


    // Update is called once per frame
    public void eat() 
    {
        fadeout.SetTrigger("On");
        basket.SetTrigger("On");
        anim.SetTrigger("On");
        close.SetTrigger("On");
    }
}
