using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject tierra;
    public GameObject esfera1;
    public GameObject esfera2;
    public GameObject preFab;
    System.Random random = new System.Random();  
    
    void Start()
    {
        float y = 73;

        Instantiate(preFab, new Vector3(Convert.ToSingle(random.NextDouble() * 100), y,  Convert.ToSingle(random.NextDouble() * 100)), transform.rotation);
        Instantiate(preFab, new Vector3(Convert.ToSingle(random.NextDouble() * 100), y, Convert.ToSingle(random.NextDouble() * 100)), transform.rotation);
        Instantiate(preFab, new Vector3(Convert.ToSingle(random.NextDouble() * 100), y, Convert.ToSingle(random.NextDouble() * 100)), transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        esfera1.transform.RotateAround(tierra.transform.position, tierra.transform.up, -10f * Time.deltaTime);
        esfera2.transform.RotateAround(tierra.transform.position, tierra.transform.up, 10f * Time.deltaTime);
    }
}
