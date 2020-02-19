using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonesMenu : MonoBehaviour
{

	public Canvas _CanvasOpciones;

	// Use this for initialization
	void Start () {
		ActivarCanvasOpciones(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	/// <summary>
	/// Carga la escena Juego
	/// </summary>
	public void BtNuevaPartida()
	{
		GameController.TiempoPausado = false;
		Time.timeScale = 1;
		SceneManager.LoadScene("Juego");
	}
	
	/// <summary>
	/// Activa el Canvas del menú de opciones.
	/// </summary>
	public void BtOpciones()
	{
		ActivarCanvasOpciones(true);
	}

	/// <summary>
	/// Cierra el canvas de opciones.
	/// </summary>
	public void BtSalirCanvasOpciones()
	{
		ActivarCanvasOpciones(false);
	}

	
	/// <summary>
	/// Activa/desactiva el componente "CanvasOpciones".
	/// </summary>
	/// <param name="estado">Boolean estado. True, activado. False, desactivado.</param>
	private void ActivarCanvasOpciones(bool estado)
	{
		_CanvasOpciones.gameObject.SetActive(estado);
	}

	/// <summary>
	/// Sale del juego.
	/// </summary>
	public void BtSalir()
	{
		Application.Quit();
	}

	/// <summary>
	/// Sonido al pasar el cursor por encima de los botones del menú.
	/// </summary>
	public void SoundMouseOver()
	{
		GameObject.Find("AudioButtonClick").GetComponent<AudioSource>().Play();
	}
}
