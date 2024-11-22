using UnityEngine;
using DG.Tweening;

public class Wood : MonoBehaviour
{
    
    void Start()
    {
        transform.DORotate(Vector3.up * 360, 2,RotateMode.FastBeyond360).SetLoops(-1).SetEase(Ease.Linear);
        DownUp();
    }

    void DownUp()
    {
        transform.DOMove(new Vector3(0f, 0.4f, 0f), 1).OnUpdate(() =>
        {
            transform.DOMove(new Vector3(0f, 0.5f, 0f), 1).OnComplete(DownUp);
        });
    }
}
