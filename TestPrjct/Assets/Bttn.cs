using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bttn : MonoBehaviour
{
    public Text tx;
    int count;

    private void Start()
    {
        count = 0;
    }
    private void Update()
    {
        tx.text = count.ToString();
    }

    public void PlusBttn()
    {
        count += 1;
    }
    public void MunusBttn()
    {
        count -= 1; 
    }
}
