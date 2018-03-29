using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLandscape_03 : MonoBehaviour {

    public int worldSizeW = 64; // x-direction
    public int worldSizeH = 64; // z-direction
    public float heightScale = 20;
    public float detailScale = 25.0f;

    public GameObject prefabGrass;

    void Start()
    {
        for (int z = 0; z < worldSizeH; z++)
        {
            for (int x = 0; x < worldSizeW; x++)
            {
                int y = (int)(Mathf.PerlinNoise(x / detailScale, z / detailScale) * heightScale);
                Vector3 pos = new Vector3(x, y, z);
                Instantiate(prefabGrass, pos, Quaternion.identity);
            }
        }
    }
}
