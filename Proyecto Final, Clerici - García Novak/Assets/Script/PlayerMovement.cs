using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float sprint = 1.5f;
    public float sprintCooldown = 3f;
    public float sprintDuration = 1.5f;
    private float sprintActualCooldown = 0;
    private Vector3 direction;
    private Vector3 playerRotation;
    public Animator animator;
    private Rigidbody rb;

    void Start()
    {
        //rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        GetInput();
        MovePlayer();
        RotatePlayer();
        Animate();
        SprintReset();
    }

    void GetInput()
    {
        direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        playerRotation = new Vector3(0f, Input.GetAxis("Mouse X"), 0f);
    }

    void MovePlayer()
    {
        if (Input.GetKey(KeyCode.LeftShift) && sprintActualCooldown < 0)
        {
            speed *= sprint;
            transform.Translate(direction.normalized * speed * Time.deltaTime);
            sprintActualCooldown = sprintCooldown;
            Invoke("ResetSpeed", sprintDuration);

        }
        else
            transform.Translate(direction.normalized * speed * Time.deltaTime);
    }

    void RotatePlayer()
    {
        transform.Rotate(playerRotation);
    }
    void Animate()
    {
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

    void SprintReset()
    {
        if (sprintActualCooldown >= 0)
        {
            sprintActualCooldown -= Time.deltaTime;
        }
    }

    private void ResetSpeed()
    {
        speed /= sprint;
    }


}

