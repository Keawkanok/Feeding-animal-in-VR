using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonVR : MainMenu , IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler, IPointerDownHandler
{
    public Color32 m_NormalColor = Color.white;
    public Color32 m_HoverColor = Color.gray;
    public Color32 m_DownColor = Color.white;
    private Image m_Image = null;

    public void Awake()
    {
        m_Image = GetComponent<Image>();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        PlayGame();
        Debug.Log("Click");
        m_Image.color = m_HoverColor;
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
  
}
