using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform[] positions; // pega posiçoes ancoras
    private Vector2 startPosition;

    private int aux = 0; // variavel de seleçao 

    void Start()
    {
        startPosition = positions[0].position;
        transform.position = startPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) // sobe posiçao
        {
            aux++;
            ChangePosition();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) // desce posiçao
        {
            aux--;
            ChangePosition();
        }
    }

    void ChangePosition()
    {
        transform.position = new Vector2(transform.position.x, positions[aux].position.y);
    }
}