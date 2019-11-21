using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class OnOffLight : MonoBehaviour
{
	public Button btOn;
	public Button btOff;
	private GameObject _luzPrincipal;
	[FormerlySerializedAs("_spotLight")] public GameObject spotLight;
	private GameObject _lightRotGameObject;
	private GameObject _slider;
	private Slider _slider1;
	private Light _light;
	private Light _lightRot;

	// Use this for initialization
	void Start ()
	{
		FindComponents();
		InitializeComponents();
		InitializeListeners();
		SetMainLightActive(true);
	}

	private void SetMainLightActive(bool active)
	{
		_luzPrincipal.SetActive(active);
	}

	private void InitializeListeners()
	{
		btOn.onClick.AddListener(OnClickBtOnListener);
		btOff.onClick.AddListener(OnClickBtOffListener);
	}

	private void InitializeComponents()
	{
		_lightRot = _lightRotGameObject.GetComponent<Light>();
		_light = spotLight.GetComponent<Light>();
		_slider1 = _slider.GetComponent<Slider>();
	}

	private void FindComponents()
	{
		_lightRotGameObject = GameObject.Find("Spot Light");
		_luzPrincipal = GameObject.FindWithTag("LuzPrincipal");
		spotLight = GameObject.FindWithTag("LightFromLightHouse");
		_slider = GameObject.Find("Slider");
	}

	// Update is called once per frame
	void Update () {
		OnValueChanged(_slider1.value);
	}

	private void OnValueChanged(float value)
	{
		setPoinLightIntensity(value);
		SetSpotLightIntensity(value);
	}

	private void SetSpotLightIntensity(float value)
	{
		_lightRot.intensity = value;
	}

	private void setPoinLightIntensity(float value)
	{
		_light.intensity = value;
	}

	private void OnClickBtOnListener()
	{
		GameObject btOffGameObject = btOff.gameObject;
		btOffGameObject.SetActive(true);
		_luzPrincipal.SetActive(false);
		GameObject btOnGameObject = btOn.gameObject;
		btOnGameObject.SetActive(false);
	}
	
	private void OnClickBtOffListener()
	{
		GameObject btOffGameObject = btOff.gameObject;
		btOffGameObject.SetActive(false);
		_luzPrincipal.SetActive(true);
		GameObject btOnGameObject = btOn.gameObject;
		btOnGameObject.SetActive(true);
	}
}