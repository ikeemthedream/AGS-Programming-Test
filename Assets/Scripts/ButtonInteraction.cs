using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonInteraction : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerUpHandler, IPointerDownHandler
{
    [SerializeField]
    GameObject button;

    Color originalColor;

    Image image;

    bool isHoveringButton = true;
    bool isPressingingButton;

    void Start()
    {
        InitialSetup();
    }

    #region Setups
    private void InitialSetup()
    {
        image = button.GetComponent<Image>();

        originalColor = image.color;
    }
    void ButtonWhenHovered()
    {
        image.color = Color.cyan;
    }
    public void ButtonWhenPressed()
    {
        image.color = Color.magenta;
    }
    #endregion
    #region Pointer Functions
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        ButtonWhenHovered();
        isHoveringButton = true;
    }
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        image.color = originalColor;
        isHoveringButton = false;

        if (isPressingingButton == true)
        {
            ButtonWhenPressed();
        }
        else
        {
            image.color = originalColor;
        }
    }
    public void OnPointerUp(PointerEventData pointerEventData)
    {
        if (isHoveringButton == false)
        {
            image.color = originalColor;
        }
        else
        {
            ButtonWhenHovered();
        }

        isPressingingButton = false;
    }
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        ButtonWhenPressed();
        isPressingingButton = true;
    }
    #endregion
}
