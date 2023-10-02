using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLookAtTarget : MonoBehaviour
{

    public Transform target;
    // Start is called before the first frame update
    private void Start()
    {
        if (target != null) return;
        target = gameObject.transform;
        Debug.Log("Target não especificado, padronizando para o próprio objeto");
    }

    private void OnMouseDown()
    {
        LookAtTarget.target = target;

        if (Camera.main == null) return;
        //Camera.main.fieldOfView = 30 / target.transform.localScale.x;
        var field0View = 30 / target.transform.localScale.x;
        Camera.main.fieldOfView = Mathf.Clamp(field0View,10,100);
    }


}
