/**
 * Autogenerated by Thrift Compiler (0.8.0)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;
using Thrift.Transport;
namespace com.think.messages
{

  [Serializable]
  public partial class UniqueSkillResponse : TBase
  {
    private int _skill_id;
    private string _skill_name;
    private byte _skill_group_id;
    private int _consume_adam_war;
    private Dictionary<byte, int> _attributeMap;
    private byte _lightType;
    private string _strategyName;
    private int _strategyIcon;

    public int Skill_id
    {
      get
      {
        return _skill_id;
      }
      set
      {
        __isset.skill_id = true;
        this._skill_id = value;
      }
    }

    public string Skill_name
    {
      get
      {
        return _skill_name;
      }
      set
      {
        __isset.skill_name = true;
        this._skill_name = value;
      }
    }

    public byte Skill_group_id
    {
      get
      {
        return _skill_group_id;
      }
      set
      {
        __isset.skill_group_id = true;
        this._skill_group_id = value;
      }
    }

    public int Consume_adam_war
    {
      get
      {
        return _consume_adam_war;
      }
      set
      {
        __isset.consume_adam_war = true;
        this._consume_adam_war = value;
      }
    }

    public Dictionary<byte, int> AttributeMap
    {
      get
      {
        return _attributeMap;
      }
      set
      {
        __isset.attributeMap = true;
        this._attributeMap = value;
      }
    }

    public byte LightType
    {
      get
      {
        return _lightType;
      }
      set
      {
        __isset.lightType = true;
        this._lightType = value;
      }
    }

    public string StrategyName
    {
      get
      {
        return _strategyName;
      }
      set
      {
        __isset.strategyName = true;
        this._strategyName = value;
      }
    }

    public int StrategyIcon
    {
      get
      {
        return _strategyIcon;
      }
      set
      {
        __isset.strategyIcon = true;
        this._strategyIcon = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool skill_id;
      public bool skill_name;
      public bool skill_group_id;
      public bool consume_adam_war;
      public bool attributeMap;
      public bool lightType;
      public bool strategyName;
      public bool strategyIcon;
    }

    public UniqueSkillResponse() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.I32) {
              Skill_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              Skill_name = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Byte) {
              Skill_group_id = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              Consume_adam_war = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.Map) {
              {
                AttributeMap = new Dictionary<byte, int>();
                TMap _map428 = iprot.ReadMapBegin();
                for( int _i429 = 0; _i429 < _map428.Count; ++_i429)
                {
                  byte _key430;
                  int _val431;
                  _key430 = iprot.ReadByte();
                  _val431 = iprot.ReadI32();
                  AttributeMap[_key430] = _val431;
                }
                iprot.ReadMapEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.Byte) {
              LightType = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.String) {
              StrategyName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.I32) {
              StrategyIcon = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("UniqueSkillResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.skill_id) {
        field.Name = "skill_id";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Skill_id);
        oprot.WriteFieldEnd();
      }
      if (Skill_name != null && __isset.skill_name) {
        field.Name = "skill_name";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Skill_name);
        oprot.WriteFieldEnd();
      }
      if (__isset.skill_group_id) {
        field.Name = "skill_group_id";
        field.Type = TType.Byte;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Skill_group_id);
        oprot.WriteFieldEnd();
      }
      if (__isset.consume_adam_war) {
        field.Name = "consume_adam_war";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Consume_adam_war);
        oprot.WriteFieldEnd();
      }
      if (AttributeMap != null && __isset.attributeMap) {
        field.Name = "attributeMap";
        field.Type = TType.Map;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.Byte, TType.I32, AttributeMap.Count));
          foreach (byte _iter432 in AttributeMap.Keys)
          {
            oprot.WriteByte(_iter432);
            oprot.WriteI32(AttributeMap[_iter432]);
          }
          oprot.WriteMapEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.lightType) {
        field.Name = "lightType";
        field.Type = TType.Byte;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(LightType);
        oprot.WriteFieldEnd();
      }
      if (StrategyName != null && __isset.strategyName) {
        field.Name = "strategyName";
        field.Type = TType.String;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(StrategyName);
        oprot.WriteFieldEnd();
      }
      if (__isset.strategyIcon) {
        field.Name = "strategyIcon";
        field.Type = TType.I32;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(StrategyIcon);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("UniqueSkillResponse(");
      sb.Append("Skill_id: ");
      sb.Append(Skill_id);
      sb.Append(",Skill_name: ");
      sb.Append(Skill_name);
      sb.Append(",Skill_group_id: ");
      sb.Append(Skill_group_id);
      sb.Append(",Consume_adam_war: ");
      sb.Append(Consume_adam_war);
      sb.Append(",AttributeMap: ");
      sb.Append(AttributeMap);
      sb.Append(",LightType: ");
      sb.Append(LightType);
      sb.Append(",StrategyName: ");
      sb.Append(StrategyName);
      sb.Append(",StrategyIcon: ");
      sb.Append(StrategyIcon);
      sb.Append(")");
      return sb.ToString();
    }

  }

}