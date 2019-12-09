using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RotateFont : MonoBehaviour
{
    public Toggle _girarDetener;

    // Use this for initialization
    public TextMeshProUGUI _menuPrincipal;

    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        RotateMenuPrincipal();
    }

    private void RotateMenuPrincipal()
    {
        if (_girarDetener.isOn)
            _menuPrincipal.transform.Rotate(50 * Time.deltaTime, 0, 0);
        else
            _menuPrincipal.transform.rotation = new Quaternion(0, 0, 0, 0);
    }
}