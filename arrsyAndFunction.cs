using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrsyAndFunction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] data = new int[10];
        ProcessArray(data);
    }

    void ProcessArray (int[] data){
        for(int i=0;i<data.Length;i++){
            data[i]= Random.Range(0,100);
            print ("the value at index is "+ data[i]);
        }
    }
}