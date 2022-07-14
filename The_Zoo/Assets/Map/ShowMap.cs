using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ShowMap : MonoBehaviour, IPointerClickHandler , IPointerExitHandler , IPointerDownHandler
{
    public GameObject UIObject;

    void Start()
    {
        UIObject.SetActive(false);
    }

    void Update()
    {
        if (time.timeValue == 0)
        {
            UIObject.SetActive(true);
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("กด");
        UIObject.SetActive(true);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
  /*      Debug.Log("ปล่อย");
        UIObject.SetActive(false);*/
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        UIObject.SetActive(false);
    }
}
