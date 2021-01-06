﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenePersist : MonoBehaviour
{
    int startingIndex;

    private void Awake()
    {
        int numScenePersist = FindObjectsOfType<ScenePersist>().Length;
        if (numScenePersist > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {   
       startingIndex = SceneManager.GetActiveScene().buildIndex;
       Debug.Log(startingIndex);
    }

    // Update is called once per frame
    void Update()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        Debug.Log(currentSceneIndex);
        if (currentSceneIndex != startingIndex)
        {
            Destroy(gameObject);
        }
    }
}
