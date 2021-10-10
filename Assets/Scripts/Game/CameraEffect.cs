using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class CameraEffect : MonoBehaviour
{
	CloudManager cloudManager;
	void OnRenderImage(RenderTexture source, RenderTexture target)
	{
		Init();

		if (cloudManager != null)
		{
			cloudManager.Render(source, target);
		}
		else
		{
			Graphics.Blit(source, target);
		}
	}

	void Init()
	{
		if (cloudManager == null)
		{
			cloudManager = FindObjectOfType<CloudManager>();
		}
	}
}
