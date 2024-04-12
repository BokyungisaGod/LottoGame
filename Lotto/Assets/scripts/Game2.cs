using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Game2 : MonoBehaviour

{
    public Animator animator1;
    public Animator animator2;
    public Animator animator3;

    public void AnimStart()
    {
        animator1.SetTrigger("In");
        animator2.SetTrigger("In");
        animator3.SetTrigger("In");
    }
}
