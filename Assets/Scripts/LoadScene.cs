using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class LoadScene : MonoBehaviour
{
    public void LoadLevel(string scene)
    {
        SceneManager.LoadScene(scene);
    }
}
