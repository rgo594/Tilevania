using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelExit : MonoBehaviour
{
    [SerializeField] float LoadLevelDelay = 2f;
    [SerializeField] float LevelExitSlowMoFactor = 0.2f;
    Scene scene;

    private void Start()
    {
        scene = SceneManager.GetActiveScene();
        Debug.Log(scene.buildIndex);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(LoadNextScene());
    }

    IEnumerator LoadNextScene()
    {
        Time.timeScale = LevelExitSlowMoFactor;
        yield return new WaitForSeconds(LoadLevelDelay);
        Time.timeScale = 1f;

        SceneManager.LoadScene(scene.buildIndex + 1);
    }
}
