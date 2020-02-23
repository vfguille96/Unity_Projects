using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverJugadorJoystick : MonoBehaviour
{
    public FixedJoystick MoveJoystick;
    public FixedButtonSalto jumpButtonSalto;
    private MoverJugador fps;
    
    // Start is called before the first frame update
    void Start()
    {
        fps = GetComponent<MoverJugador>();
    }

    // Update is called once per frame
    void Update()
    {
        fps.RunAxis = MoveJoystick.Direction;
    }
}
