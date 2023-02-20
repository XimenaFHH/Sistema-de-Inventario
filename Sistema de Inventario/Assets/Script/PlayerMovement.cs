using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float fuerzaSalto;

    private Rigidbody2D rb2D;
    private BoxCollider2D boxCollider;
    private bool MirandoDerecha = true;
    private Animator animator;

    private void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        ProcesaMovimiento();
        ProcesarSalto();
    }

    

    void ProcesarSalto()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb2D.AddForce(Vector2.up* fuerzaSalto, ForceMode2D.Impulse);
        }
    }

    private void ProcesaMovimiento()
    {
        float InputMovimiento = Input.GetAxis("Horizontal");

        if(InputMovimiento != 0f)
        {
            animator.SetBool("IsMove", true);
        }
        else
        {
            animator.SetBool("IsMove", false);
        }
        rb2D.velocity = new Vector2(InputMovimiento * speed, rb2D.velocity.y);

        GestionarOrientacion(InputMovimiento);

    }

    public void GestionarOrientacion(float InputMovimiento)
    {
        if ( (MirandoDerecha == true && InputMovimiento < 0) || (MirandoDerecha == false && InputMovimiento > 0) )
        {
            MirandoDerecha = !MirandoDerecha;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }

        
    }
}
