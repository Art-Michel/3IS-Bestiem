using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : LocalManager<UIManager>
{
    public int score;

    public TextMeshProUGUI scoreTxt;

    public void UpdateScore()
    {
        scoreTxt.text = score.ToString();
    }
}
