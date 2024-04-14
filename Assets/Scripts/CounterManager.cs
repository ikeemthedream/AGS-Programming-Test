using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CounterManager : MonoBehaviour
{
    TMP_Text counterText;

    public int counter;
    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }
    public void CountNumber()
    {
        counter++;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
