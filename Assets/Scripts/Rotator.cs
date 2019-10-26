using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    public float SlideCube = 0.0f;
    private void Update()
    {


        SlideCube = KeepData.CubeSpeed;
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime*SlideCube);
    }
}
