using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GrandmaDataHolder : MonoBehaviour
{
    [SerializeField] private float sizeMultiplier = 1f;

    public GrandmaData GrandmaData;

    private Image image;

    private Animator _animator;
    public Animator Animator
    {
        get
        {
            if (_animator == null) _animator = GetComponent<Animator>();
            return _animator;
        }
        set => _animator = value;
    }

    private void Awake()
    {
        image = GetComponent<Image>();
    }

    private void Start()
    {
        SetAnimator();
    }

    public void SetAnimator()
    {
        if (image == null) return;
        Animator.runtimeAnimatorController = GrandmaData.AnimatorController;
        Animator.Update(0f);
        RectTransform rectTransform = transform as RectTransform;
        rectTransform.sizeDelta = image.sprite.rect.size * sizeMultiplier;
    }
}
