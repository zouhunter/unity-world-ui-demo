using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;
using System;

public class Plantform : MonoBehaviour {
    [SerializeField]
    private Button m_btn;
    [SerializeField]
    private Slider m_slider;
    [SerializeField]
    private Toggle m_tog;

    private void Awake()
    {
        m_btn.onClick.AddListener(OnBtnClicked);
        m_slider.onValueChanged.AddListener(OnSliderChanged);
        m_tog.onValueChanged.AddListener(OnToggleChanged);
    }

    private void OnSliderChanged(float arg0)
    {
        Debug.Log("OnSliderChanged:" + arg0);
    }

    private void OnToggleChanged(bool arg0)
    {
        Debug.Log("OnToggleChanged:" + arg0);
    }

    private void OnBtnClicked()
    {
        Debug.Log("OnAClicked");
    }
}
