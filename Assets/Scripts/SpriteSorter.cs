using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteSorter : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _spriteRender;

    private void Update()
    {
        _spriteRender.sortingOrder = -(int)(transform.position.y * 10);
    }
}
