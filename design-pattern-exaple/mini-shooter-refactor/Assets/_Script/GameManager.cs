using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    void Awake()
    {
        if(instance != null)
        {
            instance = this;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(player == null)
        //{

        //}
    }
}
