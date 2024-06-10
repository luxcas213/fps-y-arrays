using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hambresqript : MonoBehaviour
{
    public int si=10;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<alimento>())
        {

            alimento alimento = other.GetComponent<alimento>();
            si -= alimento.valorcomida;
            Destroy(other.gameObject);
            Debug.Log(si);
        }
    }
}
