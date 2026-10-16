using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public string sceneToLoad;

    public void GoToGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}