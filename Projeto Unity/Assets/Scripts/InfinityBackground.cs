using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinityBackground : MonoBehaviour
{
    
	public float scroll_Speed = 0.1f;

	private MeshRenderer mesh_Renderer;

	private Vector2 saved_Offset;

	void Awake()
	{
		
		mesh_Renderer  = GetComponent<MeshRenderer>();

		saved_Offset = mesh_Renderer.sharedMaterial.GetTextureOffset("_MainTex");

	}

	void Update()
	{
		float y = Time.time * scroll_Speed;

		Vector2 offset = new Vector2(0, y);

		mesh_Renderer.sharedMaterial.SetTextureOffset("_MainTex",offset);

	}

	void OnDisable()
	{
		mesh_Renderer.sharedMaterial.SetTextureOffset("_MainTex", saved_Offset);
	}

}
