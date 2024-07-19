using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.UIElements;
using static Unity.Burst.Intrinsics.X86;

public class GameManager : MonoBehaviour
{
    public ClientsManage npc1Prefab, npc2Prefab, npc3Prefab, npc4Prefab;

    [SerializeField] private Transform[] balcons; // pega posições ancoras

    // variaveis
    public int randomBalcon;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnClient", 2f, UnityEngine.Random.Range(2, 8));
    }

    // Update is called once per frame
    void Update()
    {
        RandomBalcons();
    }

    void SpawnClient()
    {
        int r = UnityEngine.Random.Range(1, 5); // aleatoriza obstaculo
        Debug.Log(r);
        if (r == 1)
        {
            ClientsManage newObject = Instantiate(npc1Prefab);
            float spawnY = balcons[randomBalcon].position.y;
            float spawnX = balcons[randomBalcon].position.x;
            newObject.transform.position = new Vector2(spawnX, spawnY);
        }
        else if (r == 2)
        {
            ClientsManage newObject = Instantiate(npc2Prefab);
            float spawnY = balcons[randomBalcon].position.y;
            float spawnX = balcons[randomBalcon].position.x;
            newObject.transform.position = new Vector2(spawnX, spawnY);
        }
        else if (r == 3)
        {
            ClientsManage newObject = Instantiate(npc3Prefab);
            float spawnY = balcons[randomBalcon].position.y;
            float spawnX = balcons[randomBalcon].position.x;
            newObject.transform.position = new Vector2(spawnX, spawnY);
        }
        else if (r == 4)
        {
            ClientsManage newObject = Instantiate(npc4Prefab);
            float spawnY = balcons[randomBalcon].position.y;
            float spawnX = balcons[randomBalcon].position.x;
            newObject.transform.position = new Vector2(spawnX, spawnY);
        }
    }

    void RandomBalcons()
    {
        randomBalcon = UnityEngine.Random.Range(0, balcons.Length);
    }
}
