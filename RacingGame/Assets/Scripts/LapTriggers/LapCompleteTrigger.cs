using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapCompleteTrigger : MonoBehaviour
{
    public GameObject lapCompleteTrigger;
    public GameObject LapTrigger1;
    public GameObject Nickname;

    public GameObject MinuteDisplay;
    public GameObject SecondDisplay;
    public GameObject MilliDisplay;

    public GameObject LapTimeBox;

    private string PlayerNickname = UIManager.PlayerNickname;

    private void OnTriggerEnter()
    {
        if (LapTimeManager.SecondCount <= 9)
        {
            SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.SecondCount + ".";
        } else
        {
            SecondDisplay.GetComponent<Text>().text = "" + LapTimeManager.SecondCount + ".";
        }

        if (LapTimeManager.MinuteCount <= 9)
        {
            MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.MinuteCount + ".";
        }
        else
        {
            MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.MinuteCount + ".";
        }

        MilliDisplay.GetComponent<Text>().text = "" + LapTimeManager.MilliCount.ToString("F0");

        if (ScoreHolder.ScoreTable.ContainsKey(PlayerNickname))
        {
            if(ScoreHolder.ScoreTable[PlayerNickname] > LapTimeManager.MinuteCount * 60 * 10 + LapTimeManager.SecondCount * 10 + LapTimeManager.MilliCount)
            {
                ScoreHolder.ScoreTable[PlayerNickname] = LapTimeManager.MinuteCount * 60 * 10 + LapTimeManager.SecondCount * 10 + LapTimeManager.MilliCount;
            }
        }else
        {
            ScoreHolder.ScoreTable[PlayerNickname] = LapTimeManager.MinuteCount * 60 * 10 + LapTimeManager.SecondCount * 10 + LapTimeManager.MilliCount;
        }
        

        LapTimeManager.MinuteCount = 0;
        LapTimeManager.SecondCount = 0;
        LapTimeManager.MilliCount = 0;


        lapCompleteTrigger.SetActive(false);
        LapTrigger1.SetActive(true);
    }
}
