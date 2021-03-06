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
  public partial class FightActionResponse : TBase
  {
    private byte _opType;
    private int _attackerObjectID;
    private int _targetObjectID;
    private bool _isHoldPosition;
    private int _skillID;
    private List<HarmTargetResponse> _harmTargetList;
    private short _attackerDander;
    private byte _attackerEffect;
    private string _skillName;
    private int _image;
    private int _skill_image;
    private int _round;

    public byte OpType
    {
      get
      {
        return _opType;
      }
      set
      {
        __isset.opType = true;
        this._opType = value;
      }
    }

    public int AttackerObjectID
    {
      get
      {
        return _attackerObjectID;
      }
      set
      {
        __isset.attackerObjectID = true;
        this._attackerObjectID = value;
      }
    }

    public int TargetObjectID
    {
      get
      {
        return _targetObjectID;
      }
      set
      {
        __isset.targetObjectID = true;
        this._targetObjectID = value;
      }
    }

    public bool IsHoldPosition
    {
      get
      {
        return _isHoldPosition;
      }
      set
      {
        __isset.isHoldPosition = true;
        this._isHoldPosition = value;
      }
    }

    public int SkillID
    {
      get
      {
        return _skillID;
      }
      set
      {
        __isset.skillID = true;
        this._skillID = value;
      }
    }

    public List<HarmTargetResponse> HarmTargetList
    {
      get
      {
        return _harmTargetList;
      }
      set
      {
        __isset.harmTargetList = true;
        this._harmTargetList = value;
      }
    }

    public short AttackerDander
    {
      get
      {
        return _attackerDander;
      }
      set
      {
        __isset.attackerDander = true;
        this._attackerDander = value;
      }
    }

    public byte AttackerEffect
    {
      get
      {
        return _attackerEffect;
      }
      set
      {
        __isset.attackerEffect = true;
        this._attackerEffect = value;
      }
    }

    public string SkillName
    {
      get
      {
        return _skillName;
      }
      set
      {
        __isset.skillName = true;
        this._skillName = value;
      }
    }

    public int Image
    {
      get
      {
        return _image;
      }
      set
      {
        __isset.image = true;
        this._image = value;
      }
    }

    public int Skill_image
    {
      get
      {
        return _skill_image;
      }
      set
      {
        __isset.skill_image = true;
        this._skill_image = value;
      }
    }

    public int Round
    {
      get
      {
        return _round;
      }
      set
      {
        __isset.round = true;
        this._round = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool opType;
      public bool attackerObjectID;
      public bool targetObjectID;
      public bool isHoldPosition;
      public bool skillID;
      public bool harmTargetList;
      public bool attackerDander;
      public bool attackerEffect;
      public bool skillName;
      public bool image;
      public bool skill_image;
      public bool round;
    }

    public FightActionResponse() {
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
            if (field.Type == TType.Byte) {
              OpType = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              AttackerObjectID = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              TargetObjectID = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.Bool) {
              IsHoldPosition = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              SkillID = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.List) {
              {
                HarmTargetList = new List<HarmTargetResponse>();
                TList _list124 = iprot.ReadListBegin();
                for( int _i125 = 0; _i125 < _list124.Count; ++_i125)
                {
                  HarmTargetResponse _elem126 = new HarmTargetResponse();
                  _elem126 = new HarmTargetResponse();
                  _elem126.Read(iprot);
                  HarmTargetList.Add(_elem126);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.I16) {
              AttackerDander = iprot.ReadI16();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.Byte) {
              AttackerEffect = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.String) {
              SkillName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.I32) {
              Image = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.I32) {
              Skill_image = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 12:
            if (field.Type == TType.I32) {
              Round = iprot.ReadI32();
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
      TStruct struc = new TStruct("FightActionResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.opType) {
        field.Name = "opType";
        field.Type = TType.Byte;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(OpType);
        oprot.WriteFieldEnd();
      }
      if (__isset.attackerObjectID) {
        field.Name = "attackerObjectID";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(AttackerObjectID);
        oprot.WriteFieldEnd();
      }
      if (__isset.targetObjectID) {
        field.Name = "targetObjectID";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(TargetObjectID);
        oprot.WriteFieldEnd();
      }
      if (__isset.isHoldPosition) {
        field.Name = "isHoldPosition";
        field.Type = TType.Bool;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(IsHoldPosition);
        oprot.WriteFieldEnd();
      }
      if (__isset.skillID) {
        field.Name = "skillID";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(SkillID);
        oprot.WriteFieldEnd();
      }
      if (HarmTargetList != null && __isset.harmTargetList) {
        field.Name = "harmTargetList";
        field.Type = TType.List;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, HarmTargetList.Count));
          foreach (HarmTargetResponse _iter127 in HarmTargetList)
          {
            _iter127.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.attackerDander) {
        field.Name = "attackerDander";
        field.Type = TType.I16;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteI16(AttackerDander);
        oprot.WriteFieldEnd();
      }
      if (__isset.attackerEffect) {
        field.Name = "attackerEffect";
        field.Type = TType.Byte;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(AttackerEffect);
        oprot.WriteFieldEnd();
      }
      if (SkillName != null && __isset.skillName) {
        field.Name = "skillName";
        field.Type = TType.String;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(SkillName);
        oprot.WriteFieldEnd();
      }
      if (__isset.image) {
        field.Name = "image";
        field.Type = TType.I32;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Image);
        oprot.WriteFieldEnd();
      }
      if (__isset.skill_image) {
        field.Name = "skill_image";
        field.Type = TType.I32;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Skill_image);
        oprot.WriteFieldEnd();
      }
      if (__isset.round) {
        field.Name = "round";
        field.Type = TType.I32;
        field.ID = 12;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Round);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("FightActionResponse(");
      sb.Append("OpType: ");
      sb.Append(OpType);
      sb.Append(",AttackerObjectID: ");
      sb.Append(AttackerObjectID);
      sb.Append(",TargetObjectID: ");
      sb.Append(TargetObjectID);
      sb.Append(",IsHoldPosition: ");
      sb.Append(IsHoldPosition);
      sb.Append(",SkillID: ");
      sb.Append(SkillID);
      sb.Append(",HarmTargetList: ");
      sb.Append(HarmTargetList);
      sb.Append(",AttackerDander: ");
      sb.Append(AttackerDander);
      sb.Append(",AttackerEffect: ");
      sb.Append(AttackerEffect);
      sb.Append(",SkillName: ");
      sb.Append(SkillName);
      sb.Append(",Image: ");
      sb.Append(Image);
      sb.Append(",Skill_image: ");
      sb.Append(Skill_image);
      sb.Append(",Round: ");
      sb.Append(Round);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
