using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Field
{
    public class FieldData
    {
    }


    public class FieldNode
    {
        public Vector2 position;

        public float width;
    }
    
    public class FieldPassage
    {
        /// <summary>
        /// 통로에 속해있는 노드들
        /// </summary>
        public List<FieldNode> nodes = new List<FieldNode>();
    }

    // node component

    public class FieldObject
    {
        public int id;
        public Vector2 position;
    }
}