using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceRoll : MonoBehaviour
{
    public Animator rollAnimator;
    public GameObject rollPanel;
    public GameObject imageOne;
    public GameObject imageTwo;
    public GameObject imageThree;
    public GameObject imageFour;
    public GameObject imageFive;
    public GameObject imageSix;
    
    private int num = 0;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void roll()
    {
        rollAnimator.SetBool("isRoll", false);
                
        num = Random.Range(1, 6);
                
                if (num == 1)
                {

            imageOne.SetActive(true);
            imageTwo.SetActive(false);
            imageThree.SetActive(false);
            imageFour.SetActive(false);
            imageFive.SetActive(false);
            imageSix.SetActive(false);
            Debug.Log("num is " + num);
                }

                if (num == 2)
                {
            imageOne.SetActive(false);
            imageTwo.SetActive(true);
            imageThree.SetActive(false);
            imageFour.SetActive(false);
            imageFive.SetActive(false);
            imageSix.SetActive(false);
            Debug.Log("num is " + num);
        }

                if (num == 3)
                {
            imageOne.SetActive(false);
            imageTwo.SetActive(false);
            imageThree.SetActive(true);
            imageFour.SetActive(false);
            imageFive.SetActive(false);
            imageSix.SetActive(false);
            Debug.Log("num is " + num);
        }

                if (num == 4)
                {
            imageOne.SetActive(false);
            imageTwo.SetActive(false);
            imageThree.SetActive(false);
            imageFour.SetActive(true);
            imageFive.SetActive(false);
            imageSix.SetActive(false);
            Debug.Log("num is " + num);
        }

                if (num == 5)
                {
            imageOne.SetActive(false);
            imageTwo.SetActive(false);
            imageThree.SetActive(false);
            imageFour.SetActive(false);
            imageFive.SetActive(true);
            imageSix.SetActive(false);
            Debug.Log("num is " + num);
        }

                if (num == 6)
                {
            imageOne.SetActive(false);
            imageTwo.SetActive(false);
            imageThree.SetActive(false);
            imageFour.SetActive(false);
            imageFive.SetActive(false);
            imageSix.SetActive(true);
            Debug.Log("num is " + num);
        }
            
        
    }

    public void rollDelay()
    {
        rollAnimator.SetBool("isRoll", true);
        Invoke("roll", 4f);
    }

}