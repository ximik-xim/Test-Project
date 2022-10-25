using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEditor.UI;
using UnityEngine.EventSystems;

public class Started : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private GameObject _gameObject;
    private void Start()
    {
        Time.timeScale = 0;
    }


    public void OnPointerClick(PointerEventData eventData)
    {
        Time.timeScale = 1;
        _gameObject.SetActive(false);
    }
}
