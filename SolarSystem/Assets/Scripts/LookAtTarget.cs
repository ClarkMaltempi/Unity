using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtTarget : MonoBehaviour
{


    static public Transform target;
    // Start is called before the first frame update
    private void Start()
    {
        if (target != null) return;
        target = gameObject.transform;
        Debug.Log("Target não especificado, padronizando para o próprio objeto");
    }

    // Update is called once per frame
    private void Update()
    {
        if (target) {
            transform.LookAt(target);
        }
    }
}
