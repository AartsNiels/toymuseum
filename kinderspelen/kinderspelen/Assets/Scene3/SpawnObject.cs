using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public GameObject item;
    public GameObject spawnPos;

    public void spawnOBJ()
    {
        Instantiate(item, spawnPos.transform.position, spawnPos.transform.rotation);
    }
}
