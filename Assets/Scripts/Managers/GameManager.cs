using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : LocalManager<GameManager>
{
    [SerializeField] GameObject _canvas;
    void Start()
    {
        _canvas.SetActive(true);
    }
}
