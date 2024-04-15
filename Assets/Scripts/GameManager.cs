using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    GameObject RestartPanel;

    [SerializeField]
    SpinDial spinDial;

    [SerializeField]
    List<CounterManager> counterManagerList;

    public int masterCounter;

    // Start is called before the first frame update
    void Start()
    {
        masterCounter= 1;
    }

    public void IncrementTheMasterCounter()
    {
        if(masterCounter == 10 )
        {
            TryAgainPanel();
        }
        else
        {
            masterCounter++;
        }
    }

    #region Gameloop and Options
    private void TryAgainPanel()
    {
        RestartPanel.SetActive(true);
        spinDial.GetComponent<SpinDial>().shouldRotate = false;
    }

    public void Reset()
    {
        RestartPanel.SetActive(false);
        masterCounter = 1;
        foreach(var counter in counterManagerList )
        {
            counter.GetComponent<CounterManager>().counter = 0;

            counter.GetComponent<CounterManager>().counterText.text = counter.GetComponent<CounterManager>().counter.ToString();
        }

        spinDial.GetComponent<SpinDial>().ResetRotation();
    }

    public void CloseApplication()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
    #endregion
}
