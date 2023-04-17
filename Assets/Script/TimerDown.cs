using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerDown : MonoBehaviour
{
    [SerializeField] private Image countdown;
    public Sprite[] coundownSprites;

    [SerializeField] private float countdownTime = 3f;
    private int coundownIndex = 0;
    
    [SerializeField] private Button[] PapperRock;
    void Start()
    {
        StartCoroutine(CoundownCourotine());
    }

    private void Update()
    {
        if (!countdown.gameObject.active)
        {
            foreach (Button button in PapperRock)
            {
                button.interactable = true;
            }
                
        }
    }

    IEnumerator CoundownCourotine()
    {
        while (countdownTime > 0f)
        {
            countdown.sprite = coundownSprites[coundownIndex];
            coundownIndex++;
            countdownTime--;
            yield return new WaitForSeconds(1);
        }
        countdown.gameObject.SetActive(false);
            
    }
}
