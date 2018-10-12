using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnmatorController : MonoBehaviour {


    public Animator _Animator;


	
    public void SetActionIndex(int action)
    {
        _Animator.SetInteger("Action", action);
        _Animator.SetTrigger("Trriger");
    }
}
