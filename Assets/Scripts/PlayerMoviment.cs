using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform[] positions; // pega posições ancoras
    private Vector2 startPosition; // posição inicial
    public float lateralSpeed; // velocidade lateral
    public float returnSpeed; // velocidade de retorno
    public float leftLimit; // limite esquerdo do mapa
    public float rightLimit; // limite direito do mapa
    public GameObject SpawDrink; // spawnar cerveja

    private int aux = 0; // variavel de seleção 

    void Start()
    {
        startPosition = positions[0].position;
        transform.position = startPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.UpArrow) && transform.position.x >= rightLimit) || (Input.GetKeyDown(KeyCode.W) && transform.position.x >= rightLimit)) // sobe posição
        {
            if (aux + 1 == positions.Length) // filtro de posição para loop
            {
                aux = 0;
                ChangePositionVertical();
            }
            else
            {
                aux++;
                ChangePositionVertical();
            }
        }
        else if ((Input.GetKeyDown(KeyCode.DownArrow) && transform.position.x >= rightLimit) || (Input.GetKeyDown(KeyCode.S) && transform.position.x >= rightLimit)) // desce posição
        {
            if (aux <= 0)  // filtro de posição para loop
            {
                aux = positions.Length - 1;
                ChangePositionVertical();
            }
            else
            {
                aux--;
                ChangePositionVertical();
            }
        }

        if ((Input.GetKey(KeyCode.LeftArrow) && transform.position.x >= leftLimit) || (Input.GetKey(KeyCode.A) && transform.position.x > leftLimit)) // movimentação  horizontal
        {
            ChangePositionHorizontal();
        } else if (transform.position.x <= rightLimit) // retorno horizontal
        {
            ReturnPositionHorizontal();
        }
        Spaw();
    }

    void ChangePositionVertical() // método de movimentação vertical
    {
        transform.position = new Vector2(transform.position.x, positions[aux].position.y);
    }

    void ChangePositionHorizontal() // método de movimentação horizontal
    {
        transform.Translate(-lateralSpeed * Time.deltaTime, 0f, 0f);
    }

    void ReturnPositionHorizontal() // método de movimentação horizontal
    {
        transform.Translate(lateralSpeed * Time.deltaTime, 0f, 0f);
    }
    public void Spaw() 
    {
        if (Input.GetKeyDown(KeyCode.Space) && transform.position.x >= 0) { 
            ChangePositionVertical(); 
            Debug.Log("Tecla de espaço pressionada e position.x é maior ou igual a 0.");

            // Instanciar um novo objeto
            Instantiate(SpawDrink, transform.position, Quaternion.identity);
        }   
    }
}