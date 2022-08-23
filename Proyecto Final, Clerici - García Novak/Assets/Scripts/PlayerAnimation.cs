using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public Animator animator;
    private Vector3 direction;
    private PlayerMovement player;

    void Start()
    {
        player = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        direction = player.Direction;

        Walking();

        Running();

    }

    private void Running()
    {
        if (player.IsRunning)
        {
            animator.SetBool("isWalkingForward", false);
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }
    }

    private void Walking()
    {
        switch (direction.z)
        {
            case > 0:
                ForwardMovement();
                break;
            case < 0:
                BackwardMovement();
                break;
            case 0:
                HorizontalMovement();
                break;
        }

    }

    private void HorizontalMovement()
    {
        switch (direction.x)
        {
            case 0:
                animator.SetBool("isWalkingForward", false);
                animator.SetBool("isWalkingBackwards", false);
                animator.SetBool("isWalkingRight", false);
                animator.SetBool("isWalkingLeft", false);
                animator.SetBool("isWalkingBackLeft", false);
                animator.SetBool("isWalkingBackRight", false);
                animator.SetBool("strafeLeft", false);
                animator.SetBool("strafeRight", false);
                break;
            case < 0:
                animator.SetBool("strafeLeft", true);
                animator.SetBool("strafeRight", false);
                animator.SetBool("isWalkingForward", false);
                animator.SetBool("isWalkingBackwards", false);
                animator.SetBool("isWalkingRight", false);
                animator.SetBool("isWalkingLeft", false);
                animator.SetBool("isWalkingBackLeft", false);
                animator.SetBool("isWalkingBackRight", false);
                break;
            case > 0:
                animator.SetBool("strafeRight", true);
                animator.SetBool("strafeLeft", false);
                animator.SetBool("isWalkingForward", false);
                animator.SetBool("isWalkingBackwards", false);
                animator.SetBool("isWalkingRight", false);
                animator.SetBool("isWalkingLeft", false);
                animator.SetBool("isWalkingBackLeft", false);
                animator.SetBool("isWalkingBackRight", false);
                break;
        }
    }

    private void BackwardMovement()
    {
        switch (direction.x)
        {
            case 0:
                animator.SetBool("isWalkingForward", false);
                animator.SetBool("isWalkingRight", false);
                animator.SetBool("isWalkingLeft", false);
                animator.SetBool("isWalkingBackLeft", false);
                animator.SetBool("isWalkingBackRight", false);
                animator.SetBool("isWalkingBackwards", true);
                animator.SetBool("strafeLeft", false);
                animator.SetBool("strafeRight", false);
                break;
            case > 0:
                animator.SetBool("isWalkingForward", false);
                animator.SetBool("isWalkingRight", false);
                animator.SetBool("isWalkingLeft", false);
                animator.SetBool("isWalkingBackwards", false);
                animator.SetBool("isWalkingBackLeft", false);
                animator.SetBool("isWalkingBackRight", true);
                animator.SetBool("strafeLeft", false);
                animator.SetBool("strafeRight", false);
                break;
            case < 0:
                animator.SetBool("isWalkingForward", false);
                animator.SetBool("isWalkingRight", false);
                animator.SetBool("isWalkingLeft", false);
                animator.SetBool("isWalkingBackwards", false);
                animator.SetBool("isWalkingBackLeft", true);
                animator.SetBool("isWalkingBackRight", false);
                animator.SetBool("strafeLeft", false);
                animator.SetBool("strafeRight", false);
                break;
        }
    }

    private void ForwardMovement()
    {
        switch (direction.x)
        {
            case 0:
                animator.SetBool("isWalkingForward", true);
                animator.SetBool("isWalkingBackwards", false);
                animator.SetBool("isWalkingRight", false);
                animator.SetBool("isWalkingLeft", false);
                animator.SetBool("strafeLeft", false);
                animator.SetBool("strafeRight", false);
                animator.SetBool("isWalkingBackLeft", false);
                animator.SetBool("isWalkingBackRight", false);
                break;
            case > 0:
                animator.SetBool("isWalkingRight", true);
                animator.SetBool("isWalkingBackwards", false);
                animator.SetBool("isWalkingForward", false);
                animator.SetBool("isWalkingLeft", false);
                animator.SetBool("strafeLeft", false);
                animator.SetBool("strafeRight", false);
                animator.SetBool("isWalkingBackLeft", false);
                animator.SetBool("isWalkingBackRight", false);
                break;
            case < 0:
                animator.SetBool("isWalkingLeft", true);
                animator.SetBool("isWalkingBackwards", false);
                animator.SetBool("isWalkingForward", false);
                animator.SetBool("isWalkingRight", false);
                animator.SetBool("strafeLeft", false);
                animator.SetBool("strafeRight", false);
                animator.SetBool("isWalkingBackLeft", false);
                animator.SetBool("isWalkingBackRight", false);
                break;
        }
    }


}
