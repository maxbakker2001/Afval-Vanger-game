using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class MoveableCube : MonoBehaviour
{
    TouchControls touchControls;
    TouchControls.TouchActions touchActions;

    [SerializeField] Text debugText;

    void Start()
    {
        touchControls = new TouchControls();

        touchActions = touchControls.Touch;
        touchActions.Enable();
    }

    private void Update()
    {
        debugText.text = transform.position.x.ToString() + " / " + touchActions.TouchPosition.WasPerformedThisFrame();

        if (!touchActions.TouchPosition.WasPerformedThisFrame())
            return;

        Vector2 touchScreenInput = touchActions.TouchPosition.ReadValue<Vector2>();
        float xInput = touchScreenInput.x / 1000f - .8f;

        transform.position = new Vector3(xInput, transform.position.y, transform.position.z);
    }
}
