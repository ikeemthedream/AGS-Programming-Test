using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class SwitchInteraction : MonoBehaviour, IDragHandler,IEndDragHandler
{
    [SerializeField]
    Transform targetObject;
    private Vector3 newRotation;
    private Quaternion originalRotation;

    bool isSwitchedOn;



    // Start is called before the first frame update
    void Start()
    {
        originalRotation = targetObject.rotation;
        newRotation = new Vector3(0, 0, 45);
    }
    public void OnDrag(PointerEventData eventData)
    {
        targetObject.rotation = Quaternion.Euler(newRotation);
        CheckIfSwitchIsOn();
        Debug.Log("Drag this");
    }

    private void CheckIfSwitchIsOn()
    {
        isSwitchedOn = true;
        StartCoroutine(SwitchOperation());
    }

    IEnumerator SwitchOperation()
    {
        if (isSwitchedOn == true &&targetObject.rotation == Quaternion.Euler(newRotation))
            yield return new WaitForSeconds(2);

        targetObject.rotation = originalRotation;
        isSwitchedOn= false;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        throw new System.NotImplementedException();
    }
}
