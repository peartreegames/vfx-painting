using System;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;
using UnityEngine.Rendering;

[Serializable]
internal class InversePass : CustomPass
{
    // It can be used to configure render targets and their clear state. Also to create temporary render target textures.
    // When empty this render pass will render to the active camera render target.
    // You should never call CommandBuffer.SetRenderTarget. Instead call <c>ConfigureTarget</c> and <c>ConfigureClear</c>.
    // The render pipeline will ensure target setup and clearing happens in an performance manner.
    private Material _material;
    [SerializeField] private RenderTexture positionTexture;
    // [SerializeField] private RenderTexture colorTexture;
    protected override bool executeInSceneView => true;

    protected override void Setup(ScriptableRenderContext renderContext, CommandBuffer cmd)
    {
        if (Shader.Find("FullScreen/InversePass") != null)
            _material = CoreUtils.CreateEngineMaterial(Shader.Find("FullScreen/InversePass"));
    }

    protected override void Cleanup() => CoreUtils.Destroy(_material);

    protected override void Execute(CustomPassContext ctx)
    {
        ctx.cmd.BeginSample("Inverse Projection");
        ctx.cmd.Blit(ctx.cameraColorBuffer, positionTexture, _material, 0);
        ctx.cmd.EndSample("Inverse Projection");
    }
}