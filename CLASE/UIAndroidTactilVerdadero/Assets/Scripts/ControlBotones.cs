using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBotones : MonoBehaviour
{
	private float _vel = 5;	// Mov. XY
	private float _velZoom = 0.05F;
	
	// Movimientos
	private bool up = false;
	private bool down = false;
	private bool rigth = false;
	private bool left = false;
	private bool zoomIn = false;
	private bool zoomOut = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (rigth)
			transform.Translate((Vector3.right * Time.deltaTime * _vel));
		if (left)
			transform.Translate((Vector3.left * Time.deltaTime * _vel));
		if (up)
			transform.Translate((Vector3.up * Time.deltaTime * _vel));
		if (down)
			transform.Translate((Vector3.down * Time.deltaTime * _vel));
		
		if (zoomIn)
			transform.localScale = new Vector3(transform.localScale.x + _velZoom, 
											transform.localScale.y + _velZoom, 
											transform.localScale.z + _velZoom);
		if (zoomOut)
			transform.localScale = new Vector3(transform.localScale.x - _velZoom, 
											transform.localScale.y - _velZoom, 
											transform.localScale.z - _velZoom);
	}
	
	// Métodos control mov.
	public void MoveRight() { rigth = true; }
	public void MoveLeft() { left = true; }
	public void MoveUp() { up = true; }
	public void MoveDown() { down = true; }

	public void Stop()
	{
		up = false;
		down = false;
		rigth = false;
		left = false;
		zoomIn = false;
		zoomOut = false;
	}

	// Métodos control zoom
	public void ZommIn() { zoomIn = true; }
	public void ZoomOut() { zoomOut = true; }
}
