using UnityEngine;
using UnityEngine.EventSystems;


public class SwitchInteraction : MonoBehaviour, IDragHandler
{
    [SerializeField]
    GameObject offOnSwitchPanel;
    [SerializeField]
    GameObject switchCounter;

    public bool isToggled;

    public void OnDrag(PointerEventData eventData)
    {
        offOnSwitchPanel.GetComponent<OffOnSwitch>().CheckIfSwitchIsOn();
        switchCounter.GetComponent<CounterManager>().CountNumber();

        isToggled = !isToggled;
    }

}

