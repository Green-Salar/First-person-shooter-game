using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crosshair : MonoBehaviour
{

  private RectTransform rect;
  public float speed;
  private float currentSize;
  [Range(60,250)]
  public float size;
  private void Start(){

    rect = GetComponent<RectTransform>();

  }

  private void Update(){
      currentSize = Mathf.Lerp(currentSize, size, Time.deltaTime * speed);
    rect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, currentSize);
     rect.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, currentSize);
    }
}
