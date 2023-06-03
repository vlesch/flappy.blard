using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicManager : MonoBehaviour
{
    public int PlayerScore;
    public Text scoretext;

    [ContextMenu("Increase Score")]

    public void AddScore()
    {
        PlayerScore = PlayerScore + 1;
        scoretext.text = PlayerScore.ToString();
    }
}
