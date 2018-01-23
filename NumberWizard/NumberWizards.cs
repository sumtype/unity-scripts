using UnityEngine;
using System.Collections;

public class NumberWizards:MonoBehaviour {
  int max = 0;
  int min = 0;
  int guess = 0;
  void Start() {
    StartGame();
  }
  void Update() {
    if(Input.GetKeyDown(KeyCode.UpArrow)) {
      min = guess;
      NextGuess();
    } else if(Input.GetKeyDown(KeyCode.DownArrow)) {
      max = guess;
      NextGuess();
    } else if(Input.GetKeyDown(KeyCode.Return)) {
      print("Win!");
      StartGame();
    }
  }
  void StartGame() {
    max = 1000;
    min = 1;
    guess = 500;
    print("========================");
    print("Welcome to Number Wizard");
    print("Pick a number in your head, but don't tell me!");
    print("The highest number you can pick is " + max + ".");
    print("The lowest number you can pick is " + min + ".");
    print("Is the number higher or lower than " + guess + "?");
    print("Up arrow for higher, down for lower, return key for equal.");
    max++;
  }
  void NextGuess() {
    guess = (max + min) / 2;
    print("Higher or lower than " + guess + "?");
  }
}
