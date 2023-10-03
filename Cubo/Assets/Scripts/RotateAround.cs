using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{

    public Transform target;
    public float speed;
    public float xTilt;

    // Start is called before the first frame update
    void Start()
    {
        if (target != null) return;

        target = gameObject.transform;
        Debug.Log(message: "target não especificado, padronizando para o próprio objeto.");

    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 seria x:0 point y:1 girar em torno do y, z:
        transform.RotateAround(target.position, new Vector3(xTilt, 1, 0), speed + Time.deltaTime);

    }
}
