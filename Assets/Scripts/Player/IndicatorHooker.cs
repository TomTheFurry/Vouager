using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IndicatorHooker : MonoBehaviour
{
    public ArrowIndicator indicator;
    RotationBar speedBar;
    Tooltip speedBarTooltip;

    private void Start()
    {
        CanvasHandler canvas = FindObjectOfType<CanvasHandler>();
        speedBar = canvas.cornerHud.speedbar.GetComponentInChildren<RotationBar>();
        speedBarTooltip = canvas.cornerHud.speedbar.GetComponent<Tooltip>();
    }

    void Update()
    {
        Vector3 localVelocity = transform.InverseTransformVector(GetComponent<Rigidbody>().velocity);
        indicator.setValue(localVelocity);
        speedBar.SetValue(localVelocity.magnitude);
        speedBarTooltip.text = string.Format("Speed: {0:0} m/s", localVelocity.magnitude);
    }
}
