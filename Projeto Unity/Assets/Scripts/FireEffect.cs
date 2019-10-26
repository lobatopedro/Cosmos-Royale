using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireEffect : MonoBehaviour
{
    public float tamanhoMinimo;
    public float tamanhoNormal;
    public float tamanhoMaximo;

    private ParticleSystem fogo;
    private Joystick joystick;

    // Start is called before the first frame update
    void Start()
    {
        fogo = GetComponent<ParticleSystem>();
        joystick = FindObjectOfType<Joystick>();
    }

    // Update is called once per frame
    void Update()
    {
        if (joystick.Vertical > 0)
        {

        }
    }

    void deixarFogoNeutro()
    {
        if (joystick.Vertical == 0 && joystick)
        {

        }
    }


}
