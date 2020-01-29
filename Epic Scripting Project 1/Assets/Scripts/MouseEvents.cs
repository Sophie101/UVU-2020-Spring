using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseEvents : MonoBehaviour
{

    public UnityEvent mouseDownEvent, mouseUpEvent, mouseDragEvent, mouseEnterEvent, mouseExitEvent, mouseOverEvent;

 private void OnMouseDown()
  {
      mouseDownEvent.Invoke();
  } 
  private void OnMouseUp()
  {
      mouseUpEvent.Invoke();
  }
  private void OnMouseDrag()
  {
      mouseDragEvent.Invoke();
  }
  private void OnMouseEnter()
  {
      mouseEnterEvent.Invoke();
  }
  private void OnMouseExit()
  {
      mouseExitEvent.Invoke();
  }
  private void OnMouseOver()
  {
      mouseOverEvent.Invoke();
  }
}
