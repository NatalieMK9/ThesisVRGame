using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System.Collections.Generic;

[RequireComponent(typeof(EventTrigger))]
public class SpriteTextButton : MonoBehaviour,
IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
{
	#region Public Properties
	public Image targetImage;
	public Text targetText;
	
	public Sprite hoverSprite;
	public Color hoverTextColor;
	public Sprite pressedSprite;
	public Color pressedTextColor;
	
	public UnityEvent OnClick;
	#endregion
	//--------------------------------------------------------------------------------
	#region Private Properties
	Sprite normalSprite;
	Color normalTextColor;
	bool tracking;
	bool inBounds;
	#endregion
	//--------------------------------------------------------------------------------
	#region Interface Methods
	void Start() {
		normalSprite = targetImage.sprite;
		normalTextColor = targetText.color;
	}
	
	public void OnPointerEnter(PointerEventData eventData) {
		inBounds = true;
		UpdateStyle();
	}
	
	public void OnPointerExit(PointerEventData eventData) {
		inBounds = false;
		UpdateStyle();
	}
	
	public void OnPointerDown(PointerEventData eventData) {
		tracking = true;
		inBounds = true;
		UpdateStyle();
	}
	
	public void OnPointerUp(PointerEventData eventData) {
		if (tracking && inBounds && OnClick != null) OnClick.Invoke();
		tracking = false;
		inBounds = false;
		UpdateStyle();
	}
	#endregion
	//--------------------------------------------------------------------------------
	#region Private Methods
	void Set(Sprite sprite, Color textColor) {
		targetImage.sprite = sprite;
		targetText.color = textColor;
	}
	void UpdateStyle() {
		if (!inBounds) {
			Set(normalSprite, normalTextColor);
		} else if (tracking) {
			Set(pressedSprite, pressedTextColor);
		} else {
			Set(hoverSprite, hoverTextColor);
		}
	}
	#endregion
}