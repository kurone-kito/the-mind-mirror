using UdonSharp;
using UnityEngine;

/// <summary>相性を示すライン。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public sealed class AffinityLine : UdonSharpBehaviour
{
    /// <summary>相性レベルの最大値。</summary>
    private const int MAX_LEVEL = 4;

    /// <summary>相性レベル毎の色。</summary>
    private readonly Color[] colorByLevel =
        {
            new Color(0.7f, 0.7f, 0.7f, 0.6f),
            new Color(0f, 0.5f, 1f, 0.7f),
            new Color(0.7f, 0f, 1f, 0.8f),
            new Color(1f, 0.9f, 0f, 0.9f),
            new Color(1f, 0.3f, 0f, 0.9f),
        };

    /// <summary>相性レベル毎の線幅。</summary>
    private readonly float[] widthByLevel =
        { 0.01f, 0.02f, 0.04f, 0.07f, 0.1f };

    /// <summary>相性レベル。</summary>
    [SerializeField, Range(0, MAX_LEVEL)]
    private int level;

#pragma warning disable IDE0044
    /// <summary>ライン レンダラー。</summary>
    [SerializeField]
    private LineRenderer line;

    /// <summary>対象位置に加算する、オフセット座標。</summary>
    [SerializeField]
    private Vector3 offset;

    /// <summary>座標を固定するかどうか。</summary>
    [SerializeField]
    private bool fixPosition;
#pragma warning restore IDE0044

    /// <summary>対象の位置。</summary>
    private Vector3 target;

    /// <summary>相性レベルを取得、または設定します。</summary>
    public int Level
    {
        get => level;
        set
        {
            level = value;
            if (line != null)
            {
                UpdateState();
            }
        }
    }

    /// <summary>対象の位置を取得、または設定します。</summary>
    public Vector3 Target
    {
        get => target;
        set
        {
            target = value;
            if (line != null)
            {
                UpdatePosition();
            }
        }
    }

    /// <summary>
    /// Y 座標を固定した、座標を取得します。
    /// </summary>
    /// <param name="v">座標。</param>
    /// <param name="y">Y 座標。</param>
    /// <returns>Y 座標を固定した、座標</returns>
    private Vector3 OverrideY(Vector3 v, float y = 0.88f)
    {
        return new Vector3(v.x, y, v.z);
    }

    /// <summary>線情報のうち、位置情報を更新します。</summary>
    private void UpdatePosition()
    {
        if (fixPosition || line == null)
        {
            return;
        }
        Vector3 rnd = Vector3.one * Random.Range(-0.05f, 0.05f);
        line.SetPosition(0, OverrideY(transform.position + rnd));
        line.SetPosition(1, OverrideY(Target + offset));
    }

    /// <summary>線情報のうち、太さや色情報を更新します。</summary>
    private void UpdateState()
    {
        if (line == null)
        {
            return;
        }
        int lv = Mathf.Clamp(level, 0, MAX_LEVEL);
        line.startWidth = widthByLevel[lv];
        line.endWidth = widthByLevel[lv];
        line.material.color = colorByLevel[lv];
    }

#pragma warning disable IDE0051
    /// <summary>初期化時に呼び出される、コールバック。</summary>
    private void Start()
    {
        UpdatePosition();
        UpdateState();
    }
#pragma warning restore IDE0051
}
