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

    }
    public void Back()
    {

    }
    public void Leave()
    {
        Application.Quit(2);
    }
}
