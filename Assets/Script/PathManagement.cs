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
        
        public void CreatePath(Texture tex, Vector3 vec)
        {
            //Creating + placing texture
            GameObject path = GameObject.CreatePrimitive(PrimitiveType.Quad);
            MeshRenderer meshRenderer = path.GetComponent<MeshRenderer>();
            meshRenderer.material.mainTexture = tex;
            TransforPath(vec);
        }

        private void TransforPath(Vector3 vec)
        {
            Vector3 currentPos = vec;
            currentPos.y += 1;
            m_PathPawn.transform.position = currentPos;
        }

        public void TogglePathCreation()
        {
            m_PathDestory = !m_PathDestory;
        }

        public GameObject m_PathPawn { get; private set; }
        public bool m_PathDestory { get; private set; } = true;

    }

}
