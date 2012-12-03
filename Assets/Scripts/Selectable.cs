using UnityEngine;
using System.Collections;

public class Selectable : MonoBehaviour {
	
	private Material originalMaterial;
	private Vector3 m_Destination;
	private Vector3 m_OriginalPosition;
	private float speed = 3.0f;
	
	// Use this for initialization
	void Start () {
		originalMaterial = gameObject.renderer.material;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (IsSelected)
		{
			gameObject.renderer.material.color = Color.blue;
			if (m_Destination != Vector3.zero && m_Destination != gameObject.transform.position)
			{
				gameObject.transform.position = Vector3.Lerp (gameObject.transform.position, m_Destination, Time.deltaTime * speed);
			}
		}
		else
			gameObject.renderer.material = originalMaterial;
		
	}
	
	public void StartHover ()
    {
		if (!IsSelected) 
		{
        	gameObject.renderer.material.color = Color.green;
		}
    }
 
    public void StopHover ()
    {
        //gameObject.renderer.material.color = Color.red;
    }

    public void OnRightClick ()
    {
        
    }

    public void OnLeftClick ()
    {
		if (!IsSelected)
			GameController.instance.Selected = gameObject;
    }
	
	public bool IsSelected  {
		get 
		{
			return GameController.instance.Selected == gameObject;
		}
	}
	
	public void MoveTo(Vector3 pos)
	{
		//m_OriginalPosition = transform.position;
		m_Destination = pos;
	}
}
