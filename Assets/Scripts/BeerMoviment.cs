using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeerMoviment : MonoBehaviour
{
    void Update()
    {
        transform.Translate(-10 * Time.deltaTime, 0, 0);
        if (gameObject.transform.position.x < -12f)

            Destroy(gameObject);
    }
}
