using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameObject scoreText;
    void Start()
    {
        var dict = new Dictionary<string, float>(ScoreHolder.ScoreTable);
        var text = "";
        if (dict.Count>0)
        {
            
            for (int i = 0; i < 2; i++)
            {
                var keyOfMaxValue =
                dict.Aggregate((x, y) => x.Value < y.Value ? x : y).Key;
                var timeInMillis = ScoreHolder.ScoreTable[keyOfMaxValue];
                var minutes = (ScoreHolder.ScoreTable[keyOfMaxValue] - ScoreHolder.ScoreTable[keyOfMaxValue] % (60 * 10)) / (60 * 10);
                timeInMillis -= minutes * 60 * 10;
                var seconds = (ScoreHolder.ScoreTable[keyOfMaxValue] - ScoreHolder.ScoreTable[keyOfMaxValue] % 10) / 10;
                timeInMillis -= seconds * 10;
                text += $"{i + 1}. {keyOfMaxValue} Time: {minutes}:{seconds}.{timeInMillis.ToString("F0")}\n";
                dict.Remove(keyOfMaxValue);
                if (dict.Count <= 0)
                {
                    break;
                }
            }
        }

        scoreText.GetComponent<Text>().text = text;
    }
}
