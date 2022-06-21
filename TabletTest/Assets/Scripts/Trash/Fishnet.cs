using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Fishnet : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI counterText;
    public static float counter;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Trash>())
        {
            Destroy(other.gameObject);
            counter += .1f;
            counter = Mathf.Round(counter * 10.0f) * .1f;

        }
    }

    private void Start()
    {
        counter = 0;
    }

    private void Update()
    {
        counterText.text = "Kg afval: " + counter;
    }
}
