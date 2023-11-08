using Assets.Scripts.CameraPositions;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public static string PlayerNickname { get; set; }

    public GameObject ExitCanvas;
    public GameObject NicknameHolder;

    private bool EscapePressed;
    private bool YPressed;
    private bool NPressed;
    private bool blockEsc = false;
    private bool exitCanvasActive = false;
    // Start is called before the first frame update

    public void Start()
    {
        ExitCanvas.SetActive(false);
        NicknameHolder.GetComponent<Text>().text = "Nickname: " + PlayerNickname;
    }

    // Update is called once per frame
    void Update()
    {
        EscapePressed = Input.GetKey(KeyCode.Escape);
        if (EscapePressed && !blockEsc)
        {
            exitCanvasActive = !exitCanvasActive;
            BlockEscAsync();
            ExitCanvas.SetActive(exitCanvasActive);
        }
        YPressed = Input.GetKey(KeyCode.Y);
        NPressed = Input.GetKey(KeyCode.N);
        if (exitCanvasActive)
        {
            if (YPressed)
            {
                SceneManager.LoadScene(0);
            }
            if (NPressed)
            {
                ExitCanvas.SetActive(false);
                exitCanvasActive=false;
            }
        }

    }

    async Task BlockEscAsync()
    {
        blockEsc = true;
        await Task.Delay(1000);
        blockEsc = false;
    }
}
