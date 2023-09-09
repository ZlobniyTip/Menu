using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class ColorButtonOnClick : MonoBehaviour
{
    [SerializeField] private Image _button;

    private Color _onClickColor;

    private void Start()
    {
        _onClickColor = Color.green;
    }

    public void OnButtonClick()
    {
        _button.DOColor(_onClickColor, 0.5f).SetLoops(2, LoopType.Yoyo);
        transform.DOScale(1.15f, 0.5f).SetLoops(2, LoopType.Yoyo);
    }
}