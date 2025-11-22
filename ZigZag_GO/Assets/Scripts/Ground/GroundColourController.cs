using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundColorController : MonoBehaviour
{
    [SerializeField] private Material groundMaterial;
    [SerializeField] private Color[] colours;
    private int colorIndex = 0;
    [SerializeField] private float lerpValue;
    [SerializeField] private float time;
    private float currentTime;

    private void Update()
    {
        SetColorChangeTime();SetGroundMaterialSmoothColorChange();
    }

    private void SetColorChangeTime()
    {
        if (currentTime <= 0)
        {
            CheckColorIndexValue();
            currentTime = time;
        }
        else
        {
            currentTime -= Time.deltaTime;
        }
    }

    private void CheckColorIndexValue()
    {
        colorIndex++;

        if (colorIndex >= colours.Length)
        {
            colorIndex = 0;
        }
    }

    private void SetGroundMaterialSmoothColorChange()
    {
        groundMaterial.color = Color.Lerp(groundMaterial.color, colours[colorIndex], lerpValue * Time.deltaTime);
    }
    private void OnDestroy()
{
    groundMaterial.color = colours[1];
}

}
