void AdditionalLight_float(float3 WorldPos, int Index,out float3 Direction, out float3 Color, out float DistanceAtten, out float ShadowAtten )
{
	Direction = normalize(float3(0.5f,0.5f,0.25f));
	Color = float3(.0f,.0f,.0f);
	DistanceAtten = .0f;
	ShadowAtten = .0f;
#ifndef SHADERGRAPH_PREVIEW
	int pixelLightCount = GetAdditionalLightCount();
	if(Index < pixelLightCount){
		Light light = GetAdditionalLight(Index, WorldPos);


		Direction = light.direction;
		Color = light.color;
		DistanceAtten = light.distanceAttenuation;
		shadowAttenuation = light.shadowAttenuation;
	}
#endif
}
