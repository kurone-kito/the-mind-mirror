
using UdonSharp;
using UnityEngine;

/// <summary>役割相性用フィールド。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public sealed class RoleAffinityField : Observer
{
#pragma warning disable IDE0044
    /// <summary>マインドキューブ スタック。</summary>
    [SerializeField]
    private MindStack[] stacks;
#pragma warning restore IDE0044

    /// <summary>
    /// 有効なマインドキューブが一つでも存在するかどうかを取得します。
    /// </summary>
    /// <returns>
    /// 有効なマインドキューブが一つでも存在する場合は <c>true</c>。
    /// </returns>
    private bool HasCubeAnyOne()
    {
        foreach (MindStack stack in stacks)
        {
#pragma warning disable IDE0031
            MindCube cube = stack == null ? null : stack.MindCube;
            MindCubeVariables vars = cube == null ? null : cube.Variables;
#pragma warning restore IDE0031
            if (!(vars == null || vars.Empty))
            {
                return true;
            }
        }
        return false;
    }

    /// <summary>
    /// サブジェクトからの呼び出しを受けた際に呼び出す、コールバック。
    /// </summary>
    /// <param name="subject">サブジェクト本体。</param>
    public override void OnNotify(Subject subject)
    {
        if (subject.GetComponent<MindStack>() != null)
        {
            gameObject.SetActive(HasCubeAnyOne());
        }
    }

#pragma warning disable IDE0051
    /// <summary>初期化時に呼び出される、コールバック。</summary>
    private void Start()
    {
        gameObject.SetActive(false);
    }
#pragma warning restore IDE0051
}
