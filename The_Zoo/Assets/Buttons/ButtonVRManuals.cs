using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
public class ButtonVRManuals : MainMenu, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler
{
    public Color32 m_NormalColor = Color.white;
    public Color32 m_HoverColor = Color.gray;
    public Color32 m_DownColor = Color.white;

    private Image m_Image = null;

    private void Awake()
    {
        m_Image = GetComponent<Image>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Enter");
        m_Image.color = m_HoverColor;
        Pointer.m_DefaultLength = 5f;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Exit");
        m_Image.color = m_NormalColor;
        Pointer.m_DefaultLength = 0f;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Down");
        m_Image.color = m_DownColor;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Debug.Log("Up");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        SceneManual();
        Debug.Log("Click");
        m_Image.color = m_HoverColor;
    }
}
