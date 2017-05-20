using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineTest : MonoBehaviour
{
    private void Awake()
    {
        StartCoroutine("A");
        //A1();
    }

    IEnumerator A()
    {
        while(true)
        {
            Debug.Log("A");
            yield return new WaitForSeconds(0.5f);
        }
    }

    void A1()
    {
        while (true)
        {
            Debug.Log("A");
        }
    }
}
