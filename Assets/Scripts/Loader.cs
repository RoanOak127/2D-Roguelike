﻿using System.Collections;
using UnityEngine;

public class Loader : MonoBehaviour
{

    public GameObject gameManager;
    // Start is called before the first frame update
    void Awake()
    {
        if (GameManager.instance == null)
            Instantiate(gameManager);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
