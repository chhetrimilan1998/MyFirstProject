using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class functionD : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerClass k = new PlayerClass();

        PlayerClass wizard = new PlayerClass(55, "giant");
        wizard.Playerinfo();
        print("\n");
        ChangePlayer(wizard);
        wizard.Playerinfo();

       /* PlayerClass knight = new PlayerClass();
        knight.name = "Knight";
        knight.health = 65f;
        knight.Playerinfo();

        PlayerClass valkary = new PlayerClass();
        valkary.name = "Valkary";
        valkary.health = 48f;
        valkary.Playerinfo(); */

        /* int sum = AddTwoNumbers(17,6);
          print("the sum of two numbers is " + sum );


          print("the product of two number is "+ Multiply());
          subtraction(10,5);
          division();*/

    }
    void ChangePlayer(PlayerClass p)
    {
        p.name = "name is changed";
    }
    // Update is called once per frame
  /*  void Update()
    {
        
    }
   int AddTwoNumbers(int a, int b){
          return a+b;
   }
   int Multiply(){
          return 5*6;
    
   }
   void subtraction(int c , int d){
          print("subtraction b from a is "+(c-d));
   }
   void division(){
           int div = 35/5;
          print ("division of two numbers is "+div);
   }*/
   
}
