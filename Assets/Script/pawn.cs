using Assets.Script;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace Assets.Script
{
    public class Pawn : MonoBehaviour
    {
        public Pawn(string texPath, PawnType type, Vector2 pos, bool isHuman)
        {
            m_Type = type;
            m_Pos = pos;
            m_IsFirstMove = true;
            m_IsHuman = isHuman;
        }

        public void TestRun()
        {
            print("Testing this script");
        }

        //public
        [SerializeField]
        public Texture m_Texture;
        public Texture m_PathText;
        //[SerializeField]

        public PawnType m_Type;
        public Vector2 m_Pos;
        //private
        private bool m_IsFirstMove;
        private bool m_IsHuman; // White = human or black = Zombie;
    }
}
