using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientsManage : MonoBehaviour
{
    public float walkSpeed;
    public float limitRight;
    public float limitLeft;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < limitRight)
        {
            transform.Translate(walkSpeed * Time.deltaTime, 0f, 0f);
        }
        else if (transform.position.x < limitLeft)
        {
            Destroy(gameObject);
        }

    }
}
