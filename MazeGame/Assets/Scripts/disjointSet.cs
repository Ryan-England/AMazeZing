using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disjointSet : MonoBehaviour
{
    public int size;
    private int maxSize = 50;

    private int[] parent;
    private int[] rank;

    // Start is called before the first frame update
    void Start()
    {
        parent = new int[maxSize];
        rank = new int[maxSize];

        for (int i = 0; i < maxSize; i++)
        {
            //Debug.Log("Trying int " + i + "...");
            parent[i] = i;
            //Debug.Log("Accessed rank index " + rank[i]);
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
