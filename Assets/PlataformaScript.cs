using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformaScript : MonoBehaviour
{

    public Transform PontoA;
    public Transform PontoB;

    public int speed;

    private Vector3 targetposition;

    private void Start()
    {
        transform.position = PontoA.position; // Quando o jogo começar, a plataform irá o pontoA
        targetposition = PontoB.position; // Quando o jogo começar, define que o trajeto é PontoB


    }

    private void Update()
    {
        float distance = Vector3.Distance(transform.position, targetposition);

        if (distance < 0.01)
        {
            if (targetposition == PontoA.position)
            {
                targetposition = PontoB.position;
            }
            else
            {
                targetposition = PontoA.position;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, targetposition, speed * Time.deltaTime);
    }

}
