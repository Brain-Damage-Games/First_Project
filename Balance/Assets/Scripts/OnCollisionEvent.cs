using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnCollisionEvent : MonoBehaviour
{
    public LayerMask layerMask;
    public UnityEvent <Collision> onInter , onExit;
    private void OnCollisionEnter(Collision collision)
    {
        int layerTest = layerMask.value & (1 << collision.gameObject.layer);
        if (layerTest > 0)
        {
            onInter?.Invoke(collision);
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        int layerTest = layerMask.value & (1 << collision.gameObject.layer);
        if (layerTest > 0)
        {
            onInter?.Invoke(collision);
        }
    }
}
