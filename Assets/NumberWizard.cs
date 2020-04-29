using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
  int max = 1000;
  int min = 0;
  int currentGuess = 500;
  // Start is called before the first frame update
  void Start()
  {

    Debug.Log("Welcome to the game");
    Debug.Log("guessing.. " + currentGuess);



  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.UpArrow))
    {
      Debug.Log("min, max, guess" + min + ", " + max + ", " + currentGuess);
      min = currentGuess;
      print("new min, max, guess" + min + ", " + max + ", " + currentGuess);
      currentGuess = guess(min, max);
      print("after guess min, max, guess" + min + ", " + max + ", " + currentGuess);
      Debug.Log(" I guess " + currentGuess);
    }
    else if (Input.GetKeyDown(KeyCode.DownArrow))
    {
      Debug.Log("down arrow pressed");
      max = currentGuess;
      currentGuess = guess(min, max);
      Debug.Log(" I guess " + currentGuess);
    }
    else if (Input.GetKeyDown(KeyCode.Return))
    {
      Debug.Log("game won");
    }



  }

  int guess(int min, int max)
  {
    // Debug.Log((max - min / 2) + min);
    return ((max - min) / 2) + min;
  }
}
