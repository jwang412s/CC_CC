using UnityEngine;
using UnityEngine.EventSystems;

public class CardToHand : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public GameObject Hand;
    public GameObject HandCard;
    public GameObject ConfirmationUI;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Hand = GameObject.Find("Hand");
        HandCard.transform.SetParent(Hand.transform);
        HandCard.transform.localScale = new Vector3(1, 1, 1);
        HandCard.transform.position = new Vector3(transform.position.x, transform.position.y, -48);
        HandCard.transform.eulerAngles = new Vector3(25, 0, 0);
    }

    public void OnDrag(PointerEventData eventData)
    {
        HandCard.transform.position = eventData.position;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {

    }

    public void OnEndDrag(PointerEventData eventData)
    {
        GameObject confirmUI = Instantiate(ConfirmationUI, transform.position, transform.rotation);
    }
}
