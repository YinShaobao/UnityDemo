using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corner : MonoBehaviour
{
    // Start is called before the first frame update
    private Canvas mainCanvas;
    public float minX;
    public float maxY;

    void Start()
    {
        mainCanvas = GetComponent<Canvas>();
        minX = mainCanvas.GetComponent<RectTransform>().position.x + mainCanvas.GetComponent<RectTransform>().rect.xMin;
        maxY = mainCanvas.GetComponent<RectTransform>().position.y + mainCanvas.GetComponent<RectTransform>().rect.yMax;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
