using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       int[] data = new int[10];

       for(int i =0;i<data.Length;i++){
              data [i]= Random.Range(0,100);
        //      print ("the value at index "+ i + " is the value "+ data[i]);
       }
       foreach(int num in data){
              print ("the value at index is "+ num);
       }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
