
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinDial : MonoBehaviour
{
    [SerializeField]
    RectTransform dialTransform;

    RectTransform originalTransform;

    [SerializeField]
    int speed;

    [SerializeField]
    SwitchInteraction switchInteraction;

    bool isToggled;
    
    public bool shouldRotate;

    // Start is called before the first frame update
    void Start()
    {
        
        speed = -500;

    }

    // Update is called once per frame 
    void Update()
    {
        RotateDial();
    }


    public void RotateDial()
    {
        isToggled = switchInteraction.GetComponent<SwitchInteraction>().isToggled;
        if (shouldRotate)
        {
            if (isToggled)
            {
                RotateRight();
            }
            else
            {
                RotateLeft();
            }
        }
    }

    public void RotateRight()
    {
        dialTransform.Rotate(0, 0, -speed * Time.deltaTime);
    }
    public void RotateLeft()
    {
        dialTransform.Rotate(0, 0, speed * Time.deltaTime);
    }
    public void ResetRotation()
    {
        dialTransform.localRotation = Quaternion.identity;
    }
}
