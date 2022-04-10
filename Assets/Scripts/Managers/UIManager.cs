using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : ProjectManager<UIManager>
{
    public int score;

    public TextMeshProUGUI scoreTxt;

    void Start()
    {
        score = 0;
    }

    public void UpdateScore()
    {
        scoreTxt.text = score.ToString();
    }
}
