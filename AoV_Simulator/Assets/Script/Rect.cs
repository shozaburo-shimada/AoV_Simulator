using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rect : MonoBehaviour
{
    private RectTransform rect;
    private Vector2 TopRight;
    private Vector2 TopLeft;
    private Vector2 BottomLeft;
    private Vector2 BottomRight;
    List<Vector2> my2DPoint;

    // Start is called before the first frame update
    void Start()
    {
        rect = gameObject.GetComponent<RectTransform>();

        var offsetMax = rect.offsetMax;
        var offsetMin = rect.offsetMin;

        TopRight = new Vector2(Screen.width , Screen.height + offsetMax.y);
        TopLeft = new Vector2(offsetMin.x, Screen.height + offsetMax.y);
        BottomLeft = new Vector2(offsetMin.x, offsetMin.y);
        BottomRight = new Vector2(Screen.width + offsetMax.x, offsetMin.y);

        my2DPoint.Add(BottomLeft);
        my2DPoint.Add(BottomRight);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
