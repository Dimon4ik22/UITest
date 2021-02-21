using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveCube : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public GameObject Player;
    public bool ifButtonPressed;
    public void OnPointerDown(PointerEventData eventData)
    {
        ifButtonPressed = true;
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        ifButtonPressed = false;
    }
    public void Update()
    {
        if (ifButtonPressed)
        {
            Player.transform.Translate(2 * Time.deltaTime, 0, 0);
        }
    }
}
