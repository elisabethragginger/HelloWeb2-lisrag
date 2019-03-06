using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LislsSwitcha : MonoBehaviour
{
    public void LoadScene1()
    {
        SceneManager.LoadScene("HelloWeb");
    }

    public void LoadScene2()
    {
        SceneManager.LoadScene("HelloWeb2");
    }
}
