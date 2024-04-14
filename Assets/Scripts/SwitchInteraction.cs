using UnityEngine;
using UnityEngine.EventSystems;


    public class SwitchInteraction : MonoBehaviour, IDragHandler
    {
    [SerializeField]
    GameObject offOnSwitchPanel;

    private void Start()
    {

    }

    public void OnDrag(PointerEventData eventData)
        {
        offOnSwitchPanel.GetComponent<OffOnSwitch>().CheckIfSwitchIsOn();
        Debug.Log("Drag this");
        }

    }

