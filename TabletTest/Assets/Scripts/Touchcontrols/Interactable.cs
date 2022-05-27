using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField] float startPosY;
    [SerializeField] float loweredPosY;

    [Space, SerializeField] float minCooldown = 3;
    [SerializeField] float maxCooldown = 5;
    bool inCooldown;

    private void Start()
    {
        HookTriggered();   
    }

    public void HookTriggered()
    {
        if (inCooldown)
            return;

        transform.position = new Vector3(transform.position.x, startPosY, transform.position.z);

        StartCoroutine(HookCooldown(Random.Range(minCooldown, maxCooldown)));
    }

    IEnumerator HookCooldown(float cooldown)
    {
        inCooldown = true;

        yield return new WaitForSeconds(cooldown);

        transform.position = new Vector3(transform.position.x, loweredPosY, transform.position.z);

        inCooldown = false;
    }
}
