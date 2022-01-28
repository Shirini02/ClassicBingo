using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scaler : MonoBehaviour
{
	[SerializeField] CanvasScaler canvasScalar;

	void Start()
    {
		float currentRatio = (float)Screen.height / Screen.width;
		canvasScalar.matchWidthOrHeight = Mathf.Clamp01(Remap(1.33f, 2.3f, currentRatio, 1f, 0f));
	}

	public static float Remap(float min, float max, float value, float newMin, float newMax)
	{
		return newMin + (newMax - newMin) * ((value - min) / (max - min));
	}
}
