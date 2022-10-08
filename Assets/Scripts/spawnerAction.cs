using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerAction : MonoBehaviour
{
    public float width = 10f, height = 5f;
    public GameObject PianoTile;
    public float delay = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        SpawnUntil();
    }
    void OnDrawGizmos()
    {
        Gizmos.DrawWireCube(transform.position, new Vector3(width, height, 0));
    }

    // Update is called once per frame
    void Update()
    {
        if (CheckforEmpty())
        {
            SpawnUntil();
        }
    }

    void Spawner()
    {
        foreach (Transform child in transform)
        {
            GameObject Piano = Instantiate(PianoTile, child.position, Quaternion.identity);
            Piano.transform.parent = child;

        }
    }

    void SpawnUntil()
    {
        Transform position = freePosition();
        if (position)
        {
            GameObject Piano = Instantiate(PianoTile, position.transform.position, Quaternion.identity);
            Piano.transform.parent = position;
        }
        if (freePosition())
        {
            Invoke("SpawnUntil", delay);
        }
    }

    bool CheckforEmpty()
    {
        foreach(Transform child in transform)
        {
            if(child.childCount > 0)
            {
                return false;
            }
        }
        return true;
    }

    Transform freePosition()
    {
        foreach (Transform child in transform)
        {
            if (child.childCount == 0)
            {
                return child;
            }
        }
        return null;
    }
}
