using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conditional : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    /* int a=5;
    int b= 9;
    int c= 7;
    if(a>b && a>c){
        print (a+ " is greatest");
    }
    else if(b>c){
            print (b + " is greatest");
    }
    else 
    print (c+ " is greatest");
    }

    // Update is called once per frame
    void Update()
    {*/
    char a = 'i';
    switch (a){
    case 'a':
    print(a + " is a vowel letter");
    break;

    case 'e':
    print(a + " is a vowel letter");
    break;

    case 'i':
    print(a + " is a vowel letter");
    break;

    case 'o':
    print(a + " is a vowel letter");
    break;

    case 'u':
    print(a + " is a vowel letter");
    break;
   
    defaultcase:
    print(a + " is a consonent letter");
    break;
    }
        
    }
}
