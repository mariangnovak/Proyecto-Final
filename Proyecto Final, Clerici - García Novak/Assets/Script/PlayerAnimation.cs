using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator animator;
    private Vector3 direction;

    void Start()
    {

    }

    void Update()
    {
        direction = GetComponent<PlayerMovement>().Direction;

        if (direction.z > 0)
        {
            animator.SetBool("isRunningForward", true);
            animator.SetBool("isRunningBackwards", false);
        }
        else if (direction.z < 0)
        {
            animator.SetBool("isRunningForward", false);
            animator.SetBool("isRunningBackwards", true);
        }
        else
        {
            animator.SetBool("isRunningForward", false);
            animator.SetBool("isRunningBackwards", false);
        }
    }
}
