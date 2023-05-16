using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour
{
    [SerializeField] private Text _text1;
    [SerializeField] private Text _text2;
    [SerializeField] private Text _text3;

    private void Start()
    {
        _text1.DOText("Я заменил этот текст.", 3);
        _text2.DOText(" Это дополнение к тексту", 3).SetRelative();
        _text3.DOText("Я взломал этот текст", 3,true,ScrambleMode.All);
        _text3.DOColor(Color.red, 3);
    }
}
