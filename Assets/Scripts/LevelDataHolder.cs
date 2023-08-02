using UnityEngine;

public class LevelDataHolder : MonoBehaviour
{
    [HideInInspector] public ShellMeshContainer shellMeshContainer;
    [HideInInspector] public PeelingMesh peelingMesh;
    [HideInInspector] public Rotater rotater;
    [HideInInspector] public IKnife _knife;
    [HideInInspector] public CutterBase cutterBase;

    private void Awake()
    {
        shellMeshContainer = GetComponentInChildren<ShellMeshContainer>();
        peelingMesh = GetComponentInChildren<PeelingMesh>();
        rotater = GetComponentInChildren<Rotater>();
        _knife = GetComponentInChildren<IKnife>();
        cutterBase = GetComponentInChildren<CutterBase>();
    }
}