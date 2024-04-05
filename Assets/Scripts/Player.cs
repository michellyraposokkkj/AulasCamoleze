using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    public Rigidbody2D rig;
    public int speed;
    public int força;
    public bool podePular;
    public bool puloDuplo;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Movimento();
        Pulo();
    }

    void Movimento()
    {
        rig.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rig.velocity.y);
    }

    void Pulo()
    {
        if (Input.GetButtonDown("Jump"))


        {

            if (podePular)
            {



                rig.AddForce(Vector2.up * força, ForceMode2D.Impulse);
                podePular = false;
                puloDuplo = true;

            }
            else if (puloDuplo)
            {
                rig.AddForce(Vector2.up * força, ForceMode2D.Impulse);
                podePular = false;
                puloDuplo = false;
            }

            
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
      if (collision.gameObject.CompareTag("Chão"))
        {
            podePular = true;

        }
            
        
    }
}
