using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooler : MonoBehaviour
{
    public GameObject objectToPool;
    public List<GameObject> pooledObjects;
    public int size;
    void Start()
    {
        for (int x = 0; x < size; x++){
            pooledObjects.Add(Instantiate(objectToPool));
        }
    }

    public List<GameObject> GetPooledObjectsList(){
        return pooledObjects;
    }
}
