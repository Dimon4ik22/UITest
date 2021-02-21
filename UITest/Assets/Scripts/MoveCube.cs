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
        Debug.Log("d");
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        ifButtonPressed = false;
        Debug.Log("u");
    }
    public void Update()
    {
        if (ifButtonPressed)
        {
            Player.transform.Translate(2 * Time.deltaTime, 0, 0);
        }
    }
}
