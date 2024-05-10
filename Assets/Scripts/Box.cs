using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Box : MonoBehaviour
{
    [SerializeField] Button false_answer;
    [SerializeField] TextMeshProUGUI false_buttontext;
    [SerializeField] TextMeshProUGUI buttontext;
    [SerializeField] Button right_answer;
    [SerializeField] TextMeshProUGUI textMeshPro;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        false_answer.interactable = true;
        false_buttontext.alpha = 255;
        textMeshPro.alpha = 255;
        right_answer.interactable = true;
        buttontext.alpha = 255;
    }
    public void Riight()
    {
        right_answer.interactable= false;
        textMeshPro.alpha= 0;
        buttontext.alpha= 0;
        false_answer.interactable = false;
        false_buttontext.alpha = 0;
    }
    public void falseAnswer()
    {
        false_answer.interactable = true;
        false_buttontext.alpha = 255;
        textMeshPro.alpha = 255;
        right_answer.interactable = true;
        buttontext.alpha = 255;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
