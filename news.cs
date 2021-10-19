using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class news : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("1.Esfera");
    }

    // Update is called once per frame
    int contador;
    void Update()
    {
        contador++;
    }

    private void OnDisable()
    {
        Debug.Log(contador);
    }

}
