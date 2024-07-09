using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform[] positions; // pega posi��es ancoras
    private Vector2 startPosition;

    private int aux = 0; // variavel de sele��o 

    void Start()
    {
        startPosition = positions[0].position;
        transform.position = startPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) // sobe posi��o
        {
            if (aux + 1 == positions.Length) // filtro de posi��o para loop
            { 
                aux = 0;
                ChangePosition();
            } else {
                aux++;
                ChangePosition();
            }
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) // desce posi��o
        {
            if (aux <= 0)  // filtro de posi��o para loop
            {
                aux = positions.Length - 1;
                ChangePosition();
            }
            else
            {
                aux--;
                ChangePosition();
            }
        }
    }

    void ChangePosition() // m�todo de movimenta��o
    {
        transform.position = new Vector2(transform.position.x, positions[aux].position.y);
    }
}