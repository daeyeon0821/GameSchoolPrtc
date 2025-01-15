using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Blackboard_Default : MonoBehaviour, IBlackboardBase
{
    public float JumpForce = 3f;
    public float moveSpeed = 3.0f;
   
    public Animator animator;
    public Rigidbody rigidbody;

    public new void InitBlackboard()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();
    }   
}
