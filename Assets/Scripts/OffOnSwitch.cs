using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class OffOnSwitch : MonoBehaviour
{
    [SerializeField]
    GameObject switchOff;
    [SerializeField]
    GameObject switchOn;


    public void CheckIfSwitchIsOn()
    {
        StartCoroutine(SwitchOperation());
    }

    IEnumerator SwitchOperation()
    {
        switchOff.SetActive(false);
        switchOn.SetActive(true);
        yield return new WaitForSeconds(2.5f);
        switchOff.SetActive(true);
        switchOn.SetActive(false);
    }
}

