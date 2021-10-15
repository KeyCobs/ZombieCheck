using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using UnityEngine;

namespace Assets.Script
{
    class PathManagement
    {
        
        public void GenerateMovements(Texture tex, Vector3 vec)
        {
            //Creating + placing texture
            GameObject path = GameObject.CreatePrimitive(PrimitiveType.Quad);
            vec.y += 1.0f;
            path.transform.position += vec; 
            MeshRenderer meshRenderer = path.GetComponent<MeshRenderer>();
            meshRenderer.material.mainTexture = tex;
            TransforPath(vec);
        }

        private Vector3 TransforPath(Vector3 vec)
        {
            Vector3 currentPos = vec;
            currentPos.y += 8.0f;
            return currentPos;
        }


       
        public bool m_PawnFirstMove { get; private set; } = true;

    }

}
