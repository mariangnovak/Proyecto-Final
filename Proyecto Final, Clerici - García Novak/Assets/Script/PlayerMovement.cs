using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 5f;
    private Vector3 direction;
    private Vector3 playerRotation;

    public Vector3 Direction { get => direction; set => direction = value; }

    void Start()
    {

    }

    void Update()
    {
        GetInput();
        MovePlayer();
        RotatePlayer();
    }

    void GetInput()
    {
        direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Vertical"));
        playerRotation = new Vector3(0f, Input.GetAxis("Mouse X"), 0f);
    }

    void MovePlayer()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void RotatePlayer()
    {
        transform.Rotate(playerRotation);
    }
}

