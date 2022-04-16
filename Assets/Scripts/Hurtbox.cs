using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hitbox : MonoBehaviour
{
    void Update()
    {
        Collider2D collider = Physics2D.OverlapBox((Vector2)transform.position, new Vector2(0.2f, 0.2f), 0);
        if (collider)
        {
            if (collider.CompareTag("Ennemy"))
            {
                SoundManager.Instance.DeathSound();
                Invoke(("ChangeScene"), 0.2f);
            }
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(3);
    }
}
