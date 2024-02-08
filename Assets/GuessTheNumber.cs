using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Windows;

public class GuessTheNumber : MonoBehaviour
{
    [SerializeField] TMP_Text header;
    [SerializeField] TMP_InputField input;

    public Button newButton;
    int randomNumber; 
    int guess;
    int numGuesses = 3;


    // Start is called before the first frame update
    void Start()
    {
        GameSetup();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameSetup()
    {
        numGuesses = 3;
        randomNumber = Random.Range(1, 11);
        header.text = "I'm thinking of a number between 1 and 10. You have 3 attemps to guess it...";
        input.text = "";
        newButton.interactable = true;

    }

    public void SubmitGuess()
    {
       if (string.IsNullOrEmpty(input.text))
       {
            header.text = "Enter a number between 1 and 10";
       }
       
        guess = int.Parse(input.text);

       if (!(guess > 0 && guess < 11))
       {
            header.text = "Enter a number between 1 and 10";
       }
       else
       {
            if (guess == randomNumber)
            {
                header.text = "You Won!";
                newButton.interactable = false;
            }
            else
            {
                numGuesses -= 1;
                header.text = "Incorrect! You have " + numGuesses + " remaining.";
                if (numGuesses == 0)
                {
                    header.text = "Game Over";
                    newButton.interactable = false;

                }
            }
       }
       
        
    }


}
