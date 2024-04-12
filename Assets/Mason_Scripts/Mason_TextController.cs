using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mason_TextController : MonoBehaviour
{

   public void PickRadnomFromList()
   {
    string[] phrase = new string[] {"What?", "wanna hear a joke? Some find it humerus!", "Wow! Look at all that spaghetti back here. This code is a mess!", "What are you suposed to be, a Tic-Tac?", "Come here often?", "I ran out of promts :("};
    string randomPhrase = phrase[Random.Range(0, phrase.Length)];
    print(randomPhrase);
   }
}
