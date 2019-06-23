using UnityEngine.Rendering.PostProcessing;

[System.Serializable]
[PostProcess(typeof(EdgeDetectPostProcessingRenderer_BeforeTransparent), PostProcessEvent.BeforeTransparent, "Edge Detection/Edge Detection (Before Transparent)")]
public sealed class EdgeDetect_BeforeTransparent : EdgeDetectPostProcessing { }

public sealed class EdgeDetectPostProcessingRenderer_BeforeTransparent : EdgeDetectPostProcessingRenderer<EdgeDetect_BeforeTransparent> { }
