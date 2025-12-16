
using System.Collections.Generic;
using UnityEngine;

namespace Extensions.Material_Get_Set_Parameters
{
    public static class Material_Get_Set_Parameters
    {
        public class MaterialShaderParameter
        {
            public string name;
            public int id;
            public UnityEngine.Rendering.ShaderPropertyType type;
            public float[] floats;
            public int integer;
            public Color[] colors;
            public Vector4[] vectors;
            public Texture texture;
        }

        public static MaterialShaderParameter[] GetParameters(this Material self)
        {
            
            List<MaterialShaderParameter> parameters = new List<MaterialShaderParameter>();
            var shader = self.shader;
            var propertiesCount = shader.GetPropertyCount();
            for (int i = 0; i < propertiesCount; i++)
            {
                var type = shader.GetPropertyType(i);
                var id = shader.GetPropertyNameId(i);
                var paramName = shader.GetPropertyName(i);
                var materialParam = new MaterialShaderParameter { id = id, name=paramName,type = type };
                switch (type)
                {
                    case UnityEngine.Rendering.ShaderPropertyType.Color:
                        materialParam.colors = self.GetColorArray(id);
                        break;
                    case UnityEngine.Rendering.ShaderPropertyType.Float:
                    case UnityEngine.Rendering.ShaderPropertyType.Range:
                        materialParam.floats = self.GetFloatArray(id);
                        break;
                    case UnityEngine.Rendering.ShaderPropertyType.Vector:
                        materialParam.vectors = self.GetVectorArray(id);
                        break;
                    case UnityEngine.Rendering.ShaderPropertyType.Texture:
                        materialParam.texture = self.GetTexture(id);
                        break;
                    case UnityEngine.Rendering.ShaderPropertyType.Int:
                        materialParam.integer = self.GetInt(id);
                        break;
                }

                parameters.Add(materialParam);
            }
            return parameters.ToArray();
        }

        public static void SetParameters(this Material self, MaterialShaderParameter[] parameters)
        {
            if (parameters == null || parameters.Length == 0) return;
            foreach (var param in parameters)
            {
                var id = param.id;
                switch (param.type)
                {
                    case UnityEngine.Rendering.ShaderPropertyType.Color:
                        self.SetColorArray(id, param.colors);
                        break;
                    case UnityEngine.Rendering.ShaderPropertyType.Float:
                        self.SetFloatArray(id, param.floats);
                        break;
                    case UnityEngine.Rendering.ShaderPropertyType.Range:
                        self.SetFloat(id, param.floats[0]);
                        break;
                    case UnityEngine.Rendering.ShaderPropertyType.Vector:
                        self.SetVectorArray(id, param.vectors);
                        break;
                    case UnityEngine.Rendering.ShaderPropertyType.Texture:
                        self.SetTexture(id, param.texture);
                        break;
                    case UnityEngine.Rendering.ShaderPropertyType.Int:
                        self.SetInt(id, param.integer);
                        break;
                }
            }
        }
    }

}
