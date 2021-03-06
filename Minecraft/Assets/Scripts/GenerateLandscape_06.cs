﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLandscape_06 : MonoBehaviour {
    public int worldSizeW = 64; // x-direction
    public int worldSizeH = 64; // z-direction
    public float heightScale = 20;
    public float detailScale = 25.0f;

    public GameObject prefabGrass;
    public GameObject prefabSnow;
    public GameObject prefabSand;

    void Start()
    {
        int ySnow = (int)(0.7f * heightScale);
        int ySand = (int)(0.25f * heightScale);
        Random.InitState((System.DateTime.Now.Millisecond));
        float ofsX = Random.Range(0, 10);
        float ofsZ = Random.Range(0, 10);
        for (int z = 0; z < worldSizeH; z++)
        {
            for (int x = 0; x < worldSizeW; x++)
            {
                float fx = ofsX + x / detailScale;
                float fz = ofsZ + z / detailScale;
                int y = (int)(Mathf.PerlinNoise(fx, fz) * heightScale);
                Vector3 pos = new Vector3(x, y, z);
                if (y >= ySnow)
                {
                    Instantiate(prefabSnow, pos, Quaternion.identity);
                }
                else if (y <= ySand){
                    Instantiate(prefabSand, pos, Quaternion.identity);
                }
                else
                {
                    Instantiate(prefabGrass, pos, Quaternion.identity);
                }
            }
        }
    }
}
