using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public void nextScene(int sceneANumber)
    {
        SceneManagement.LoadScene(sceneANumber);
    }
}

internal class SceneManagement
{
    internal static void LoadScene(int sceneANumber)
    {
        throw new NotImplementedException();
    }
}