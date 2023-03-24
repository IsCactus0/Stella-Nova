#if OPENGL
#define SV_POSITION POSITION
#define VS_SHADERMODEL vs_3_0
#define PS_SHADERMODEL ps_3_0
#else
#define VS_SHADERMODEL vs_4_0_level_9_1
#define PS_SHADERMODEL ps_4_0_level_9_1
#endif

Texture2D SpriteTexture;

sampler2D SpriteTextureSampler = sampler_state
{
    Texture = <SpriteTexture>;
};

struct VertexShaderOutput
{
    float4 Position : SV_POSITION;
    float4 Color : COLOR0;
    float2 TextureCoordinates : TEXCOORD0;
};

float4 MainPS(VertexShaderOutput input) : COLOR
{   
    float4 texColour = tex2D(SpriteTextureSampler, input.TextureCoordinates);
    float4 blendedColor = texColour * input.Color;
    
    float1 posX = abs(input.TextureCoordinates.x - 0.5f);
    float1 posY = abs(input.TextureCoordinates.y - 0.5f);    
    float1 distance = sqrt(posX * posX + posY * posY);
    float1 distNormalised = (distance - 1.0f) * -2.0f;
    // float1 average = (blendedColor.r + blendedColor.g + blendedColor.b) / 3.0f;
    
    distNormalised *= distNormalised;
    // blendedColor.rgb = average;
    blendedColor.a = distNormalised;
    
    return blendedColor;
}

technique SpriteDrawing
{
    pass P0
    {
        PixelShader = compile PS_SHADERMODEL
        MainPS();
    }
};