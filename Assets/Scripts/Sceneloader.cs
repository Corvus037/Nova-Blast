using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Sceneloader : MonoBehaviour
{
    public string targetScene;

    public void ChangeScene()
    {
        SceneManager.LoadScene(targetScene);
    }
}