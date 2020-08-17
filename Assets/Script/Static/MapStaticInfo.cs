using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

namespace Static
{
    public class MapStaticInfo
    {
        [XmlAttribute("id")]
        public int id;

        [XmlElement("Location")]
        public List<MapLocation> locationList;
        [XmlElement("Trigger")]
        public List<MapTrigger> triggerList;
        [XmlElement("Object")]
        public List<MapObjectPlace> mapObjectList;
    }

    public class MapLocation
    {
        public int left;
        public int right;
    }
    public class MapTrigger
    {
        public List<TriggerCondition> conditions;
        public List<TriggerAciton> acitons;
    }

    public enum TriggerConditionType
    {
        Always,
        Bring
    }

    public class TriggerCondition
    {
        public TriggerConditionType type;
        public int iParam1;
        public int iParam2;
    }

    public enum TriggerActionType
    {
        TeleportToMap
    }

    public class TriggerAciton
    {
        public TriggerActionType type;
        public int iParam1;
        public int iParam2;
    }

    /// <summary>
    /// 맵 오브젝트 배치 정보
    /// </summary>
    public class MapObjectPlace
    {
        public int x;
        public int y;
        public string targetObjectId;
    }
}