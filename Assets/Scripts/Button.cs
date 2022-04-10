using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    [SerializeField] int nbscene;

    public void Play()
    {
        SceneManager.LoadScene(nbscene);
    }
    public void Credits()
    {
        SceneManager.LoadScene(1);
    }
    public void Reload()
    {
        SceneManager.LoadScene(nbscene);
    }
    public void Back()
    {
        SceneManager.LoadScene(0);
    }
    public void Leave()
    {
        Application.Quit(2);
    }
}
