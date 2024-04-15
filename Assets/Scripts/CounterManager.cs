using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CounterManager : MonoBehaviour
{
    public  TMP_Text counterText;

    [SerializeField]
    GameManager manager;

    public int counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }
    public void CountNumber()
    {
        counter++;

        counterText.text = counter.ToString();

        manager.GetComponent<GameManager>().IncrementTheMasterCounter();

    }
}
