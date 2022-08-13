using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    enum comportamientos { Seguir, Mirar };
    [SerializeField] Transform objetivoTransform;

    [SerializeField] comportamientos comportamiento;

    public int velocidad = 5;

    public Animator animator;

    public float velocidadRotacion = 2f;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        objetivoTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        switch (comportamiento)
        {
            case comportamientos.Seguir:
                ChasePlayer();
                break;

            case comportamientos.Mirar:
                LookPlayerLerp();
                break;

        }
    }

    void ChasePlayer()
    {
        Vector3 direccion = (objetivoTransform.position - transform.position);
        LookPlayer();

        if (direccion.magnitude >= 2)
        {
            transform.position += direccion.normalized * velocidad * Time.deltaTime;
            animator.SetBool("Stab Attack", false);
            animator.SetBool("Walk Forward", true);
        }
        else if (animator.GetBool("Walk Forward"))
        {
            animator.SetBool("Walk Forward", false);
            animator.SetBool("Stab Attack", true);
        }


    }

    void LookPlayerLerp()
    {
        Quaternion rotacion = Quaternion.LookRotation(objetivoTransform.position - transform.position);

        transform.rotation = Quaternion.Lerp(transform.rotation, rotacion, velocidadRotacion * Time.deltaTime);
    }

    void LookPlayer()
    {
        transform.LookAt(objetivoTransform);
    }
}
