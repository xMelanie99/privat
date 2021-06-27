using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Fusee.Engine.Core;
using Fusee.Engine.Core.Scene;
using Fusee.Engine.Core.Effects;
using Fusee.Math.Core;
using Fusee.Serialization;

namespace FuseeApp
{
    public static class SimpleMeshes
    {
        public static Mesh CreateCuboid(float3 size)
        {
            return new Mesh
            {
                Vertices = new[]
                {
                    new float3 {x = +0.5f * size.x, y = -0.5f * size.y, z = +0.5f * size.z},
                    new float3 {x = +0.5f * size.x, y = +0.5f * size.y, z = +0.5f * size.z},
                    new float3 {x = -0.5f * size.x, y = +0.5f * size.y, z = +0.5f * size.z},
                    new float3 {x = -0.5f * size.x, y = -0.5f * size.y, z = +0.5f * size.z},
                    new float3 {x = +0.5f * size.x, y = -0.5f * size.y, z = -0.5f * size.z},
                    new float3 {x = +0.5f * size.x, y = +0.5f * size.y, z = -0.5f * size.z},
                    new float3 {x = +0.5f * size.x, y = +0.5f * size.y, z = +0.5f * size.z},
                    new float3 {x = +0.5f * size.x, y = -0.5f * size.y, z = +0.5f * size.z},
                    new float3 {x = -0.5f * size.x, y = -0.5f * size.y, z = -0.5f * size.z},
                    new float3 {x = -0.5f * size.x, y = +0.5f * size.y, z = -0.5f * size.z},
                    new float3 {x = +0.5f * size.x, y = +0.5f * size.y, z = -0.5f * size.z},
                    new float3 {x = +0.5f * size.x, y = -0.5f * size.y, z = -0.5f * size.z},
                    new float3 {x = -0.5f * size.x, y = -0.5f * size.y, z = +0.5f * size.z},
                    new float3 {x = -0.5f * size.x, y = +0.5f * size.y, z = +0.5f * size.z},
                    new float3 {x = -0.5f * size.x, y = +0.5f * size.y, z = -0.5f * size.z},
                    new float3 {x = -0.5f * size.x, y = -0.5f * size.y, z = -0.5f * size.z},
                    new float3 {x = +0.5f * size.x, y = +0.5f * size.y, z = +0.5f * size.z},
                    new float3 {x = +0.5f * size.x, y = +0.5f * size.y, z = -0.5f * size.z},
                    new float3 {x = -0.5f * size.x, y = +0.5f * size.y, z = -0.5f * size.z},
                    new float3 {x = -0.5f * size.x, y = +0.5f * size.y, z = +0.5f * size.z},
                    new float3 {x = +0.5f * size.x, y = -0.5f * size.y, z = -0.5f * size.z},
                    new float3 {x = +0.5f * size.x, y = -0.5f * size.y, z = +0.5f * size.z},
                    new float3 {x = -0.5f * size.x, y = -0.5f * size.y, z = +0.5f * size.z},
                    new float3 {x = -0.5f * size.x, y = -0.5f * size.y, z = -0.5f * size.z}
                },

                Triangles = new ushort[]
                {
                    // front face
                    0, 2, 1, 0, 3, 2,

                    // right face
                    4, 6, 5, 4, 7, 6,

                    // back face
                    8, 10, 9, 8, 11, 10,

                    // left face
                    12, 14, 13, 12, 15, 14,

                    // top face
                    16, 18, 17, 16, 19, 18,

                    // bottom face
                    20, 22, 21, 20, 23, 22

                },

                Normals = new[]
                {
                    new float3(0, 0, 1),
                    new float3(0, 0, 1),
                    new float3(0, 0, 1),
                    new float3(0, 0, 1),
                    new float3(1, 0, 0),
                    new float3(1, 0, 0),
                    new float3(1, 0, 0),
                    new float3(1, 0, 0),
                    new float3(0, 0, -1),
                    new float3(0, 0, -1),
                    new float3(0, 0, -1),
                    new float3(0, 0, -1),
                    new float3(-1, 0, 0),
                    new float3(-1, 0, 0),
                    new float3(-1, 0, 0),
                    new float3(-1, 0, 0),
                    new float3(0, 1, 0),
                    new float3(0, 1, 0),
                    new float3(0, 1, 0),
                    new float3(0, 1, 0),
                    new float3(0, -1, 0),
                    new float3(0, -1, 0),
                    new float3(0, -1, 0),
                    new float3(0, -1, 0)
                },

                UVs = new[]
                {
                    new float2(1, 0),
                    new float2(1, 1),
                    new float2(0, 1),
                    new float2(0, 0),
                    new float2(1, 0),
                    new float2(1, 1),
                    new float2(0, 1),
                    new float2(0, 0),
                    new float2(1, 0),
                    new float2(1, 1),
                    new float2(0, 1),
                    new float2(0, 0),
                    new float2(1, 0),
                    new float2(1, 1),
                    new float2(0, 1),
                    new float2(0, 0),
                    new float2(1, 0),
                    new float2(1, 1),
                    new float2(0, 1),
                    new float2(0, 0),
                    new float2(1, 0),
                    new float2(1, 1),
                    new float2(0, 1),
                    new float2(0, 0)
                },
                BoundingBox = new AABBf(-0.5f * size, 0.5f * size)
            };
        }

        public static SurfaceEffect MakeMaterial(float4 color)
        {
            return MakeEffect.FromDiffuseSpecular(
                albedoColor: color,
                emissionColor: float4.Zero,
                shininess: 25.0f,
                specularStrength: 1f);
        }

        public static Mesh CreateCylinder(float radius, float height, int segments)
        {
            float3[] verts = new float3[4 * segments + 2];    // one vertex per segment and one extra for the center point
            float3[] norms = new float3[4 * segments + 2];    // one normal at each vertex
            ushort[] tris = new ushort[segments * 3 * 4];  // a triangle per segment. Each triangle is made of three indices

            // Mittelpunkt vom Kreis für die obere Deckenfläche
            verts[4 * segments] = new float3(0, 0.5f * height, 0);
            norms[4 * segments] = float3.UnitY;

            verts[4 * segments + 1] = new float3(0, -0.5f * height, 0);
            norms[4 * segments + 1] = -float3.UnitY;

            //oberer
            norms[0] = float3.UnitY;
            verts[0] = new float3(radius, 0.5f * height, 0);

            norms[1] = new float3(radius, 0, 0); ;
            verts[1] = new float3(radius, 0.5f * height, 0);

            //unterer
            norms[2] = new float3(radius, 0, 0); ;
            verts[2] = new float3(radius, -0.5f * height, 0);

            norms[3] = float3.UnitY;
            verts[3] = new float3(radius, -0.5f * height, 0);

            float delta = 2 * M.Pi / segments;

            for (int i = 1; i < segments; i++) //(int i = 1; i <= segments; i++)
            {
            
                verts[4 * i + 0] = new float3(radius * M.Cos(i * delta), 0.5f * height, radius * M.Sin(i * delta)); //erste Punkt
                verts[4 * i + 1] = new float3(radius * M.Cos(i * delta), 0.5f * height, radius * M.Sin(i * delta));
                verts[4 * i + 2] = new float3(radius * M.Cos(i * delta), -0.5f * height, radius * M.Sin(i * delta));
                verts[4 * i + 3] = new float3(radius * M.Cos(i * delta), -0.5f * height, radius * M.Sin(i * delta));

                norms[4 * i + 0] = float3.UnitY;
                norms[4 * i + 1] = new float3(M.Cos(i * delta), 0, M.Sin(i * delta));
                norms[4 * i + 2] = new float3(M.Cos(i * delta), 0, M.Sin(i * delta));
                norms[4 * i + 3] = -float3.UnitY;

                // top triangle
                tris[12 * (i - 1) + 0] = (ushort)(4 * segments);       // top center point
                tris[12 * (i - 1) + 1] = (ushort)(4 * (i - 1) + 0);      // current top segment point
                tris[12 * (i - 1) + 2] = (ushort)(4 * i + 0);      // previous top segment point

                // side triangle 1
                tris[12 * (i - 1) + 3] = (ushort)(4 * (i - 1) + 2);      // previous lower shell point
                tris[12 * (i - 1) + 4] = (ushort)(4 * i + 2);      // current lower shell point
                tris[12 * (i - 1) + 5] = (ushort)(4 * i + 1);      // current top shell point

                // side triangle 2
                tris[12 * (i - 1) + 6] = (ushort)(4 * (i - 1) + 2);      // previous lower shell point
                tris[12 * (i - 1) + 7] = (ushort)(4 * i + 1);      // current top shell point
                tris[12 * (i - 1) + 8] = (ushort)(4 * (i - 1) + 1);      // previous top shell point

                // bottom triangle
                tris[12 * (i - 1) + 9] = (ushort)(4 * segments + 1);    // bottom center point
                tris[12 * (i - 1) + 10] = (ushort)(4 * i + 3);     // current bottom segment point
                tris[12 * (i - 1) + 11] = (ushort)(4 * (i - 1) + 3);     // previous bottom segment point

            }

            // top triangle
            tris[12 * (segments - 1) + 0] = (ushort)(segments * 4);      // top center point
            tris[12 * (segments - 1) + 1] = (ushort)(segments * 4 - 4);      // current top segment point
            tris[12 * (segments - 1) + 2] = (ushort)(0);      // previous top segment point

            // side triangle 1
            tris[12 * (segments - 1) + 3] = (ushort)(1);      // previous lower shell point
            tris[12 * (segments - 1) + 4] = (ushort)(4 * segments - 3);      // current lower shell point
            tris[12 * (segments - 1) + 5] = (ushort)(2);      // current top shell point

            // side triangle 2
            tris[12 * (segments - 1) + 6] = (ushort)(4 * segments - 3);      // previous lower shell point
            tris[12 * (segments - 1) + 7] = (ushort)(4 * segments - 2);      // current top shell point
            tris[12 * (segments - 1) + 8] = (ushort)(2);      // previous top shell point

            // bottom triangle
            tris[12 * (segments - 1) + 9] = (ushort)(4 * segments + 1);    // bottom center point
            tris[12 * (segments - 1) + 10] = (ushort)(2);     // current bottom segment point
            tris[12 * (segments - 1) + 11] = (ushort)(4 * segments - 2);     // previous bottom segment point

            return new Mesh
            {
                Vertices = verts,
                Normals = norms,
                Triangles = tris,
            };
        }

        public static Mesh CreateCone(float radius, float height, int segments)
        {
            return CreateConeFrustum(radius, 0.0f, height, segments);
        }

        public static Mesh CreateConeFrustum(float radiuslower, float radiusupper, float height, int segments)
        {
            throw new NotImplementedException();
        }

        public static Mesh CreatePyramid(float baselen, float height)
        {
            throw new NotImplementedException();
        }
        public static Mesh CreateTetrahedron(float edgelen)
        {
            throw new NotImplementedException();
        }

        public static Mesh CreateTorus(float segradius, float sliceradius, int segments, int slices)
        {
            float3[] verts = new float3[4*segments*slices];    // one vertex per segment and one extra for the center point
            float3[] norms = new float3[verts.Length];         // one normal at each vertex
            ushort[] tris = new ushort[3*2*segments*slices];   // a triangle per segment. Each triangle is made of three indices

            float deltaSegment = 2 * M.Pi / segments;
            float deltaSlice = 2 * M.Pi / slices;

            int triCount = 0;
            for(int i = 0; i < segments; i++){
                for(int j = 0; j < slices; j++){    
                    float3 slicePoint = new float3(sliceradius * M.Cos(j * deltaSlice), sliceradius * M.Sin(j * deltaSlice), 0);
                    verts[4*i*slices + 4*j] = new float3((segradius + slicePoint.x) * M.Cos(i * deltaSegment), slicePoint.y, (segradius + slicePoint.x) * M.Sin(i * deltaSegment));
                    verts[4*i*slices + 4*j + 1] = new float3((segradius + slicePoint.x) * M.Cos(i * deltaSegment), slicePoint.y, (segradius + slicePoint.x) * M.Sin(i * deltaSegment));
                    verts[4*i*slices + 4*j + 2] = new float3((segradius + slicePoint.x) * M.Cos(i * deltaSegment), slicePoint.y, (segradius + slicePoint.x) * M.Sin(i * deltaSegment));
                    verts[4*i*slices + 4*j + 3] = new float3((segradius + slicePoint.x) * M.Cos(i * deltaSegment), slicePoint.y, (segradius + slicePoint.x) * M.Sin(i * deltaSegment));

                    tris[triCount++] = (ushort) (4*i*slices + 4*j + 3);
                    tris[triCount++] = (ushort) (4*((i+1)%segments)*slices + (4*((j+1)%slices)));
                    tris[triCount++] = (ushort) (4*i*slices + (4*((j+1)%slices) + 1)); 

                    tris[triCount++] = (ushort) (4*i*slices + 4*j + 3);
                    tris[triCount++] = (ushort) (4*((i+1)%segments)*slices + (4*j + 2));
                    tris[triCount++] =  (ushort) (4*((i+1)%segments)*slices + (4*((j+1)%slices))); 

                    float3 sliceMidVecA = new float3(sliceradius * M.Cos((j+0.5f) * deltaSlice), sliceradius * M.Sin((j+0.5f) * deltaSlice), 0);  
                    float3 sliceMidVecB = new float3(sliceradius * M.Cos((j-0.5f) * deltaSlice), sliceradius * M.Sin((j-0.5f) * deltaSlice), 0); 
                    float3 segMidVecA = new float3(segradius * M.Cos((i+0.5f) * deltaSegment), 0, segradius * M.Sin((i+0.5f) * deltaSegment));
                    float3 segMidVecB = new float3(segradius * M.Cos((i-0.5f) * deltaSegment), 0, segradius * M.Sin((i-0.5f) * deltaSegment));  

                    float3 point1 = new float3((segradius + sliceMidVecB.x) * M.Cos((i-0.5f) * deltaSegment), sliceMidVecB.y, (segradius + sliceMidVecB.x) * M.Sin((i-0.5f) * deltaSegment));    
                    float3 point2 = new float3((segradius + sliceMidVecB.x) * M.Cos((i+0.5f) * deltaSegment), sliceMidVecB.y, (segradius + sliceMidVecB.x) * M.Sin((i+0.5f) * deltaSegment));
                    float3 point3 = new float3((segradius + sliceMidVecA.x) * M.Cos((i-0.5f) * deltaSegment), sliceMidVecA.y, (segradius + sliceMidVecA.x) * M.Sin((i-0.5f) * deltaSegment));
                    float3 point4 = new float3((segradius + sliceMidVecA.x) * M.Cos((i+0.5f) * deltaSegment), sliceMidVecA.y, (segradius + sliceMidVecA.x) * M.Sin((i+0.5f) * deltaSegment));
                    
                    
                    float3 v1 = (point1 - (segMidVecB));
                    float3 v2 = (point2 - (segMidVecA));
                    float3 v3 = (point3 - (segMidVecB));
                    float3 v4 = (point4 - (segMidVecA));               



                    v1.Normalize();
                    v2.Normalize();
                    v3.Normalize();
                    v4.Normalize();

                    norms[4*i*slices + 4*j] =  v1;
                    norms[4*i*slices + 4*j + 1] = v2;
                    norms[4*i*slices + 4*j + 2] = v3;
                    norms[4*i*slices + 4*j + 3] = v4;

                }
            }

            return new Mesh
            {
                Vertices = verts,
                Normals = norms,
                Triangles = tris,
            };
        }

    }
}
