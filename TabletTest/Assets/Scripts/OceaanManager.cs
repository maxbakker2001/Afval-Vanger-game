using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceaanManager : MonoBehaviour
{
    [Header("Wave Settings")]
    public float WaveHeight = 0.5f;

    public float WaveFrequency = 1f;
    public float Wavespead = 1f;

    [Header("Oceaan Object")]
    public GameObject Oceaan;

    [Header("Bestaan er shaders voor de zeetje")]
    public bool OceaanShaders = false;

    private Material OceaanMat;

    private Texture2D DisplacementWaves;

    private void Start()
    {
        if (OceaanShaders == true)
        {
            setVariables();
        }
    }

    private void setVariables()
    {
        OceaanMat = Oceaan.GetComponent<Renderer>().sharedMaterial;
        DisplacementWaves = (Texture2D)OceaanMat.GetTexture("_WavesDisplacement");
    }
}