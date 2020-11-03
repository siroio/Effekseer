//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Effekseer.swig {

public class Native : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal Native(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(Native obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~Native() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          EffekseerNativePINVOKE.delete_Native(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public Native() : this(EffekseerNativePINVOKE.new_Native(), true) {
  }

  public bool CreateWindow_Effekseer(System.IntPtr handle, int width, int height, bool isSRGBMode, DeviceType deviceType) {
    bool ret = EffekseerNativePINVOKE.Native_CreateWindow_Effekseer(swigCPtr, handle, width, height, isSRGBMode, (int)deviceType);
    return ret;
  }

  public bool UpdateWindow() {
    bool ret = EffekseerNativePINVOKE.Native_UpdateWindow(swigCPtr);
    return ret;
  }

  public void ClearWindow(byte r, byte g, byte b, byte a) {
    EffekseerNativePINVOKE.Native_ClearWindow(swigCPtr, r, g, b, a);
  }

  public void RenderWindow() {
    EffekseerNativePINVOKE.Native_RenderWindow(swigCPtr);
  }

  public void Present() {
    EffekseerNativePINVOKE.Native_Present(swigCPtr);
  }

  public bool ResizeWindow(int width, int height) {
    bool ret = EffekseerNativePINVOKE.Native_ResizeWindow(swigCPtr, width, height);
    return ret;
  }

  public bool DestroyWindow() {
    bool ret = EffekseerNativePINVOKE.Native_DestroyWindow(swigCPtr);
    return ret;
  }

  public bool LoadEffect(System.IntPtr data, int size, string path) {
    bool ret = EffekseerNativePINVOKE.Native_LoadEffect(swigCPtr, data, size, path);
    return ret;
  }

  public bool RemoveEffect() {
    bool ret = EffekseerNativePINVOKE.Native_RemoveEffect(swigCPtr);
    return ret;
  }

  public bool PlayEffect() {
    bool ret = EffekseerNativePINVOKE.Native_PlayEffect(swigCPtr);
    return ret;
  }

  public bool StopEffect() {
    bool ret = EffekseerNativePINVOKE.Native_StopEffect(swigCPtr);
    return ret;
  }

  public bool StepEffect(int frame) {
    bool ret = EffekseerNativePINVOKE.Native_StepEffect__SWIG_0(swigCPtr, frame);
    return ret;
  }

  public bool StepEffect() {
    bool ret = EffekseerNativePINVOKE.Native_StepEffect__SWIG_1(swigCPtr);
    return ret;
  }

  public bool Rotate(float x, float y) {
    bool ret = EffekseerNativePINVOKE.Native_Rotate(swigCPtr, x, y);
    return ret;
  }

  public bool Slide(float x, float y) {
    bool ret = EffekseerNativePINVOKE.Native_Slide(swigCPtr, x, y);
    return ret;
  }

  public bool Zoom(float zoom) {
    bool ret = EffekseerNativePINVOKE.Native_Zoom(swigCPtr, zoom);
    return ret;
  }

  public bool SetRandomSeed(int seed) {
    bool ret = EffekseerNativePINVOKE.Native_SetRandomSeed(swigCPtr, seed);
    return ret;
  }

  public System.IntPtr RenderView(int width, int height) { return EffekseerNativePINVOKE.Native_RenderView(swigCPtr, width, height); }

  public bool BeginRecord(RecordingParameter recordingParameter) {
    bool ret = EffekseerNativePINVOKE.Native_BeginRecord(swigCPtr, RecordingParameter.getCPtr(recordingParameter));
    if (EffekseerNativePINVOKE.SWIGPendingException.Pending) throw EffekseerNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool StepRecord(int frames) {
    bool ret = EffekseerNativePINVOKE.Native_StepRecord(swigCPtr, frames);
    return ret;
  }

  public bool EndRecord() {
    bool ret = EffekseerNativePINVOKE.Native_EndRecord(swigCPtr);
    return ret;
  }

  public bool IsRecording() {
    bool ret = EffekseerNativePINVOKE.Native_IsRecording(swigCPtr);
    return ret;
  }

  public float GetRecordingProgress() {
    float ret = EffekseerNativePINVOKE.Native_GetRecordingProgress(swigCPtr);
    return ret;
  }

  public bool IsRecordCompleted() {
    bool ret = EffekseerNativePINVOKE.Native_IsRecordCompleted(swigCPtr);
    return ret;
  }

  public bool Record(RecordingParameter recordingParameter) {
    bool ret = EffekseerNativePINVOKE.Native_Record(swigCPtr, RecordingParameter.getCPtr(recordingParameter));
    if (EffekseerNativePINVOKE.SWIGPendingException.Pending) throw EffekseerNativePINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public ViewerParamater GetViewerParamater() {
    ViewerParamater ret = new ViewerParamater(EffekseerNativePINVOKE.Native_GetViewerParamater(swigCPtr), true);
    return ret;
  }

  public void SetViewerParamater(ViewerParamater paramater) {
    EffekseerNativePINVOKE.Native_SetViewerParamater(swigCPtr, ViewerParamater.getCPtr(paramater));
    if (EffekseerNativePINVOKE.SWIGPendingException.Pending) throw EffekseerNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public ViewerEffectBehavior GetEffectBehavior() {
    ViewerEffectBehavior ret = new ViewerEffectBehavior(EffekseerNativePINVOKE.Native_GetEffectBehavior(swigCPtr), true);
    return ret;
  }

  public void SetViewerEffectBehavior(ViewerEffectBehavior behavior) {
    EffekseerNativePINVOKE.Native_SetViewerEffectBehavior(swigCPtr, ViewerEffectBehavior.getCPtr(behavior));
    if (EffekseerNativePINVOKE.SWIGPendingException.Pending) throw EffekseerNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool SetSoundMute(bool mute) {
    bool ret = EffekseerNativePINVOKE.Native_SetSoundMute(swigCPtr, mute);
    return ret;
  }

  public bool SetSoundVolume(float volume) {
    bool ret = EffekseerNativePINVOKE.Native_SetSoundVolume(swigCPtr, volume);
    return ret;
  }

  public bool InvalidateTextureCache() {
    bool ret = EffekseerNativePINVOKE.Native_InvalidateTextureCache(swigCPtr);
    return ret;
  }

  public void SetIsGroundShown(bool value) {
    EffekseerNativePINVOKE.Native_SetIsGroundShown(swigCPtr, value);
  }

  public void SetIsGridShown(bool value, bool xy, bool xz, bool yz) {
    EffekseerNativePINVOKE.Native_SetIsGridShown(swigCPtr, value, xy, xz, yz);
  }

  public void SetGridLength(float length) {
    EffekseerNativePINVOKE.Native_SetGridLength(swigCPtr, length);
  }

  public void SetBackgroundColor(byte r, byte g, byte b) {
    EffekseerNativePINVOKE.Native_SetBackgroundColor(swigCPtr, r, g, b);
  }

  public void SetBackgroundImage(string path) {
    EffekseerNativePINVOKE.Native_SetBackgroundImage(swigCPtr, path);
  }

  public void SetGridColor(byte r, byte g, byte b, byte a) {
    EffekseerNativePINVOKE.Native_SetGridColor(swigCPtr, r, g, b, a);
  }

  public void SetMouseInverseFlag(bool rotX, bool rotY, bool slideX, bool slideY) {
    EffekseerNativePINVOKE.Native_SetMouseInverseFlag(swigCPtr, rotX, rotY, slideX, slideY);
  }

  public void SetStep(int step) {
    EffekseerNativePINVOKE.Native_SetStep(swigCPtr, step);
  }

  public bool StartNetwork(string host, ushort port) {
    bool ret = EffekseerNativePINVOKE.Native_StartNetwork(swigCPtr, host, port);
    return ret;
  }

  public void StopNetwork() {
    EffekseerNativePINVOKE.Native_StopNetwork(swigCPtr);
  }

  public bool IsConnectingNetwork() {
    bool ret = EffekseerNativePINVOKE.Native_IsConnectingNetwork(swigCPtr);
    return ret;
  }

  public void SendDataByNetwork(string key, System.IntPtr data, int size, string path) {
    EffekseerNativePINVOKE.Native_SendDataByNetwork(swigCPtr, key, data, size, path);
  }

  public void SetLightDirection(float x, float y, float z) {
    EffekseerNativePINVOKE.Native_SetLightDirection(swigCPtr, x, y, z);
  }

  public void SetLightColor(byte r, byte g, byte b, byte a) {
    EffekseerNativePINVOKE.Native_SetLightColor(swigCPtr, r, g, b, a);
  }

  public void SetLightAmbientColor(byte r, byte g, byte b, byte a) {
    EffekseerNativePINVOKE.Native_SetLightAmbientColor(swigCPtr, r, g, b, a);
  }

  public void SetIsRightHand(bool value) {
    EffekseerNativePINVOKE.Native_SetIsRightHand(swigCPtr, value);
  }

  public void SetCullingParameter(bool isCullingShown, float cullingRadius, float cullingX, float cullingY, float cullingZ) {
    EffekseerNativePINVOKE.Native_SetCullingParameter(swigCPtr, isCullingShown, cullingRadius, cullingX, cullingY, cullingZ);
  }

  public ImageResource LoadImageResource(string path) {
    global::System.IntPtr cPtr = EffekseerNativePINVOKE.Native_LoadImageResource(swigCPtr, path);
    ImageResource ret = (cPtr == global::System.IntPtr.Zero) ? null : new ImageResource(cPtr, false);
    return ret;
  }

  public int GetAndResetDrawCall() {
    int ret = EffekseerNativePINVOKE.Native_GetAndResetDrawCall(swigCPtr);
    return ret;
  }

  public int GetAndResetVertexCount() {
    int ret = EffekseerNativePINVOKE.Native_GetAndResetVertexCount(swigCPtr);
    return ret;
  }

  public int GetInstanceCount() {
    int ret = EffekseerNativePINVOKE.Native_GetInstanceCount(swigCPtr);
    return ret;
  }

  public float GetFPS() {
    float ret = EffekseerNativePINVOKE.Native_GetFPS(swigCPtr);
    return ret;
  }

  public static bool IsDebugMode() {
    bool ret = EffekseerNativePINVOKE.Native_IsDebugMode();
    return ret;
  }

  public void SetBloomParameters(bool enabled, float intensity, float threshold, float softKnee) {
    EffekseerNativePINVOKE.Native_SetBloomParameters(swigCPtr, enabled, intensity, threshold, softKnee);
  }

  public void SetTonemapParameters(int algorithm, float exposure) {
    EffekseerNativePINVOKE.Native_SetTonemapParameters(swigCPtr, algorithm, exposure);
  }

  public void OpenOrCreateMaterial(string path) {
    EffekseerNativePINVOKE.Native_OpenOrCreateMaterial(swigCPtr, path);
  }

  public void TerminateMaterialEditor() {
    EffekseerNativePINVOKE.Native_TerminateMaterialEditor(swigCPtr);
  }

  public bool GetIsUpdateMaterialRequiredAndReset() {
    bool ret = EffekseerNativePINVOKE.Native_GetIsUpdateMaterialRequiredAndReset(swigCPtr);
    return ret;
  }

  public static void SetFileLogger(string path) {
    EffekseerNativePINVOKE.Native_SetFileLogger(path);
  }

}

}
