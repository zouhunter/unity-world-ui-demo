using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using System.Collections.Generic;

public class RenderImage : Graphic
{
    [SerializeField]
    private Renderer m_renderer;
    private Material _mat;

    public override Material material
    {
        get
        {
            if (m_renderer == null)
            {
                m_renderer = GetComponentInChildren<Renderer>();
            }

            if (m_renderer != null && _mat == null)
            {
                _mat = new Material(m_renderer.sharedMaterial);
                m_renderer.material = _mat;
                Debug.Log("new material");
            }
            return _mat;
        }

        set
        {
            _mat = value;
        }
    }
    public override void CrossFadeColor(Color targetColor, float duration, bool ignoreTimeScale, bool useAlpha)
    {
        if (material)
            material.color = targetColor;
    }
    public override void CrossFadeAlpha(float alpha, float duration, bool ignoreTimeScale)
    {
        if (material)
        {
            var color = material.color;
            color.a = alpha;
            material.color = color;
        }
    }
    public override Color color
    {
        get
        {
            if (material)
                return material.color;
            return Color.clear;
        }

        set
        {
            Debug.Log(value);
            if (material)
                material.color = value;
        }
    }
    public override Material defaultMaterial
    {
        get
        {
            return m_Material;
        }
    }
}
