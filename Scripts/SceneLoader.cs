using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] float timeToLoadScene = 2f;

    private void Start()
    {
        Invoke("LoadFirstScene", timeToLoadScene);
    }

    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
}