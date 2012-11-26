using UnityEngine;
using System.Collections;

public class Selectable : MonoBehaviour {
	
	private Material originalMaterial;
	
	// Use this for initialization
	void Start () {
		originalMaterial = gameObject.renderer.material;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (IsSelected)
		{
			gameObject.renderer.material.color = Color.blue;
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
}
