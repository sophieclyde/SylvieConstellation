using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldSceneMusic : Singleton<WorldSceneMusic>
{
    // Start is called before the first frame update
    void Awake()
    {
        InitializeSingleton(gameObject);
    }

    void Start() {
        AudioManager.Instance.CheckMusic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
