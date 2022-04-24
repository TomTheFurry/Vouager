using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EndTrigger : MonoBehaviour
{
    public UnityEvent onEndTrigger;
    public float minSpeed = float.MaxValue;
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player" && other.attachedRigidbody.velocity.magnitude < minSpeed) {
            onEndTrigger.Invoke();
            enabled = false;
        }
    }

}
