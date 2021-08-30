using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleRotate : MonoBehaviour
{
    /// <summary>
    /// for cool interface stuff. 
    /// </summary>
    public bool isStatic = false; 
    
    /// <summary>
    /// Max Angles in Degrees. Set to N, Range will be -N to N in angles. 
    /// </summary>
    public float AngleAmount = 5;

    /// <summary>
    /// How fast should a complete cycle should take place in Seconds. 
    /// </summary>
    public float RotateSpeed = 3;

    /// <summary>
    /// time.deltatime is added to this each frame. 
    /// </summary>
    public float elapsedtime = 0;

    /// <summary>
    /// optization, is refreshed each frame. 
    /// </summary>
    public float elapsedtimeCOS = 0;

    public float AngleonFrame = 0; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If IsStatic is false, do nothing... 
        if (isStatic) { return; }

        elapsedtime += Time.deltaTime;

        // put elapsedtime in COS()
 
        elapsedtimeCOS = Mathf.Sin(elapsedtime / RotateSpeed);

        AngleonFrame = elapsedtimeCOS * AngleAmount;

        gameObject.transform.rotation = Quaternion.Euler(0, AngleonFrame, 0);
    }
}
