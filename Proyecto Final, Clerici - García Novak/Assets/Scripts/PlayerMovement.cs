using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float sprintSpeed = 7f;
    private Vector3 cameraRotation;
    private Vector3 direction;
    private Vector3 playerRotation;
    private bool isRunning;

    public Vector3 Direction { get => direction; set => direction = value; }
    public bool IsRunning { get => isRunning; set => isRunning = value; }

    void Start()
    {

    }

    void Update()
    {
        GetInput();
        RotatePlayer();
        MovePlayer();
    }

    void GetInput()
    {
        direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        playerRotation = new Vector3(0f, Input.GetAxis("Mouse X"), 0f);
    }

    void MovePlayer()
    {
        if (Input.GetKey(KeyCode.LeftShift) && direction.z> 0 && direction.x == 0)
        {
            Walk(sprintSpeed);
            isRunning = true;
        }
        else
        {
            Walk(speed);
            isRunning = false;
        }
    }

    void RotatePlayer()
    {
        transform.Rotate(playerRotation);
    }

    void Walk(float value)
    {
        transform.Translate(direction * value * Time.deltaTime);
    }

}

