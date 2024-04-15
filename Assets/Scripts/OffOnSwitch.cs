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
        SwitchOn();
        yield return new WaitForSeconds(2.5f);
        SwitchOff();
    }

    private void SwitchOff()
    {
        switchOff.SetActive(true);
        switchOn.SetActive(false);
    }

    private void SwitchOn()
    {
        switchOff.SetActive(false);
        switchOn.SetActive(true);
    }
}

