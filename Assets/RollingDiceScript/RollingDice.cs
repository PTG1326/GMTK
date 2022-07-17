using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RollingDice : MonoBehaviour
{
    public Animator rollAnimator;
    public GameObject rollPanel;
    public Image imageOne;
    public Image imageTwo;
    public Image imageThree;
    public Image imageFour;
    public Image imageFive;
    public Image imageSix;
    private float currTime = 0f;
    private float waitTime = 4f;
    private int num = 0;

    void Start()
    {
        rollPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("marker") && Input.GetKeyDown(KeyCode.Space))
        {
            currTime = Time.deltaTime;
            rollPanel.SetActive(true);
            if (currTime > waitTime)
            {
                rollAnimator.SetBool("isRoll", false);
                num = Random.Range(1, 6);

                if (num == 1)
                {
                    imageOne.enabled = true;
                    imageTwo.enabled = false;
                    imageThree.enabled = false;
                    imageFour.enabled = false;
                    imageFive.enabled = false;
                    imageSix.enabled = false;
                }

                if (num == 2)
                {
                    imageOne.enabled = false;
                    imageTwo.enabled = true;
                    imageThree.enabled = false;
                    imageFour.enabled = false;
                    imageFive.enabled = false;
                    imageSix.enabled = false;
                }

                if (num == 3)
                {
                    imageOne.enabled = false;
                    imageTwo.enabled = false;
                    imageThree.enabled = true;
                    imageFour.enabled = false;
                    imageFive.enabled = false;
                    imageSix.enabled = false;
                }
                
                if (num == 4)
                {
                    imageOne.enabled = false;
                    imageTwo.enabled = false;
                    imageThree.enabled = false;
                    imageFour.enabled = true;
                    imageFive.enabled = false;
                    imageSix.enabled = false;
                }

                if (num == 5)
                {
                    imageOne.enabled = false;
                    imageTwo.enabled = false;
                    imageThree.enabled = false;
                    imageFour.enabled = false;
                    imageFive.enabled = true;
                    imageSix.enabled = false;
                }

                if (num == 6)
                {
                    imageOne.enabled = false;
                    imageTwo.enabled = false;
                    imageThree.enabled = false;
                    imageFour.enabled = false;
                    imageFive.enabled = false;
                    imageSix.enabled = true;
                }
            }
        }
    }

}
