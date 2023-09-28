using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shape : MonoBehaviour
{
	private Color m_color= Color.white; // ENCAPSULATION
	public Color color// ENCAPSULATION
	{
		get { return m_color; } // ENCAPSULATION

		set // ENCAPSULATION
		{
			m_color = value;
		} 
	}

	private string m_shapeName = "Shape"; // ENCAPSULATION
	public string shapeName// ENCAPSULATION
	{
		get { return m_shapeName; } // ENCAPSULATION

		set // ENCAPSULATION
		{
			if(value == "")
			{
				Debug.LogError("Shape Name can't be void");
			}
			else
			{
				m_shapeName = value;
			}
		}
	}


	public TMP_Text text;

	public MeshRenderer Renderer;

	public virtual void DisplayText() //ABSTRACTION
	{
		text.text = "I am a " + m_shapeName;
	}

	public virtual void ColorShape() // ABSTRACTION
	{
		Material material = Renderer.material;
		material.color = color;
	}

	void Update()
	{
		// Check for left mouse button click
		if (Input.GetMouseButtonDown(0))
		{
			// Create a ray from the mouse position
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hitInfo;

			// Perform the raycast
			if (Physics.Raycast(ray, out hitInfo))
			{
				// Check if the hit object is the GameObject with MeshRenderer
				if (hitInfo.collider.gameObject == gameObject)
				{
					// The GameObject was clicked
					DisplayText();
				}
			}
		}
	}
}
