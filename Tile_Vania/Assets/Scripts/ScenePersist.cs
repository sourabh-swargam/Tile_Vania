using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenePersist : MonoBehaviour
{

    int startingSceneIndex;

    void OnEnable()
    {
        startingSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.sceneLoaded += OnSceneLoaded;

    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        int currentSceneIndex = scene.buildIndex;

        if (currentSceneIndex != startingSceneIndex)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
    }

    private void Awake()
    {

        int numPersistObjects = FindObjectsOfType<ScenePersist>().Length;
        if (numPersistObjects > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

}
