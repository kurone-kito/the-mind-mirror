using UdonSharp;
using UnityEngine;
using VRC.SDKBase;

using TrackingData = VRC.SDKBase.VRCPlayerApi.TrackingData;
using TrackingDataType = VRC.SDKBase.VRCPlayerApi.TrackingDataType;

/// <summary>ビルボード。</summary>
[UdonBehaviourSyncMode(BehaviourSyncMode.None)]
public sealed class Billboard : UdonSharpBehaviour
{
#pragma warning disable IDE0051
    /// <summary>毎フレーム呼び出す、コールバック。</summary>
    private void Update()
    {
        VRCPlayerApi player = Networking.LocalPlayer;
        if (player == null)
        {
            return;
        }
        TrackingData data = player.GetTrackingData(TrackingDataType.Head);
        Vector3 offset = transform.position - data.position;
        transform.rotation = Quaternion.LookRotation(offset);
    }
#pragma warning restore IDE0051
}
