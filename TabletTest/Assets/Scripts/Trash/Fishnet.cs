using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Fishnet : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI counterText;
    public static float counter;

    public ParticleSystem ps;
    

    private void OnCollisionEnter(Collision other)
    { 
        if (other.gameObject.GetComponent<Trash>())
        {
            Destroy(other.gameObject);
            ps.Play();
            counter += .1f;
            counter = Mathf.Round(counter * 10.0f) * .1f;
        }
    }

    private void Awake()
    {
        counter = 0;
    }

    private void Update()
    {
        counterText.text = "Kg afval: " + counter;
    }

 
}
