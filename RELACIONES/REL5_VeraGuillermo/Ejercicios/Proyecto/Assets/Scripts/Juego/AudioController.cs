using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    public AudioMixer _AudioMixer;
    public Slider _sliderMaster;
    public Slider _sliderMusica;
    public Slider _sliderEfectos;

    private static float Master;
    private static float Musica;
    private static float Efectos;

    private void Start()
    {
        InicializarSlidersEcualizador();
    }

    private void InicializarSlidersEcualizador()
    {
        if (_sliderMaster.value != Master)
            _sliderMaster.value = Master;
        if (_sliderMusica.value != Musica)
            _sliderMusica.value = Musica;
        if (_sliderEfectos.value != Efectos)
            _sliderEfectos.value = Efectos;
    }

    public void VolumenMaster(float volumen)
    {
        _AudioMixer.SetFloat("Master", volumen);
        Master = volumen;
    }

    public void VolumenMusica(float volumen)
    {
        _AudioMixer.SetFloat("Musica", volumen);
        Musica = volumen;
    }

    public void VolumenEfectos(float volumen)
    {
        _AudioMixer.SetFloat("Efectos", volumen);
        Efectos = volumen;
    }
}