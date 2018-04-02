﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLandscape_02 : MonoBehaviour {

    public int worldSizeW = 64; // x-direction
    public int worldSizeH = 64; // z-direction

    public GameObject prefabGrass;

    void Start() {
        for (int z = 0; z < worldSizeH; z++) {
            for (int x = 0; x < worldSizeW; x++) {
                int y = (int)Random.Range(0, 10);
                Vector3 pos = new Vector3(x, y, z);
                Instantiate(prefabGrass, pos, Quaternion.identity);
            }
        }
    }
}