using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlFireSound : MonoBehaviour
{
    private AudioSource controleAudio;
    private Joystick joystick;

    public float tamanhoMinimo;
    public float tamanhoNormal;
    public float tamanhoMaximo;

    private float valorAtual;

    // Start is called before the first frame update
    void Start()
    {
        valorAtual = tamanhoNormal;
        controleAudio = GetComponent<AudioSource>();
        joystick = FindObjectOfType<Joystick>();
    }

    // Update is called once per frame
    void Update()
    {
        verificaAceleracao();
        controleAudio.volume = valorAtual;

    }

    public void verificaAceleracao()
    {
        if (joystick.Vertical > 0 && valorAtual < tamanhoMaximo) //Aumentar Fogo
        {
            valorAtual += 0.0010f;
        }

        if (joystick.Vertical < 0 && valorAtual > tamanhoMinimo) //Diminuir Fogo
        {
            valorAtual -= 0.0010f; ;
        }

        if (joystick.Vertical == 0 && valorAtual > tamanhoNormal)
        {
            valorAtual -= 0.0010f; ;
        }
        else
        if (joystick.Vertical == 0 && valorAtual < tamanhoNormal)
        {
            valorAtual += 0.0010f; ;
        }
    }
}
