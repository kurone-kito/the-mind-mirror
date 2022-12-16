using UdonSharp;
using UnityEngine;

/// <summary>出版-購読型モデルにおける、サブジェクト側のクラス。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public class Subject : UdonSharpBehaviour
{
#pragma warning disable IDE0044
    /// <summary>オブザーバーのリスト。</summary>
    [SerializeField]
    private Observer[] observers;
#pragma warning restore IDE0044

    /// <summary>オブザーバーを呼び出します。</summary>
    public virtual void Notify()
    {
        foreach (Observer observer in observers)
        {
            if (observer == null)
            {
                continue;
            }
            observer.OnNotify(this);
        }
    }
}
