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
  public partial class LegionFightResponse : TBase
  {
    private int _id;
    private List<LegionFightPlayerResponse> _attacker;
    private List<LegionFightPlayerResponse> _target;
    private Dictionary<int, byte> _winningStreakMap;
    private byte _fightListSum;
    private List<LegionFightAction> _actions;
    private bool _isWin;
    private AwardResponse _award;
    private int _scene;

    public int Id
    {
      get
      {
        return _id;
      }
      set
      {
        __isset.id = true;
        this._id = value;
      }
    }

    public List<LegionFightPlayerResponse> Attacker
    {
      get
      {
        return _attacker;
      }
      set
      {
        __isset.attacker = true;
        this._attacker = value;
      }
    }

    public List<LegionFightPlayerResponse> Target
    {
      get
      {
        return _target;
      }
      set
      {
        __isset.target = true;
        this._target = value;
      }
    }

    public Dictionary<int, byte> WinningStreakMap
    {
      get
      {
        return _winningStreakMap;
      }
      set
      {
        __isset.winningStreakMap = true;
        this._winningStreakMap = value;
      }
    }

    public byte FightListSum
    {
      get
      {
        return _fightListSum;
      }
      set
      {
        __isset.fightListSum = true;
        this._fightListSum = value;
      }
    }

    public List<LegionFightAction> Actions
    {
      get
      {
        return _actions;
      }
      set
      {
        __isset.actions = true;
        this._actions = value;
      }
    }

    public bool IsWin
    {
      get
      {
        return _isWin;
      }
      set
      {
        __isset.isWin = true;
        this._isWin = value;
      }
    }

    public AwardResponse Award
    {
      get
      {
        return _award;
      }
      set
      {
        __isset.award = true;
        this._award = value;
      }
    }

    public int Scene
    {
      get
      {
        return _scene;
      }
      set
      {
        __isset.scene = true;
        this._scene = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool id;
      public bool attacker;
      public bool target;
      public bool winningStreakMap;
      public bool fightListSum;
      public bool actions;
      public bool isWin;
      public bool award;
      public bool scene;
    }

    public LegionFightResponse() {
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
              Id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.List) {
              {
                Attacker = new List<LegionFightPlayerResponse>();
                TList _list209 = iprot.ReadListBegin();
                for( int _i210 = 0; _i210 < _list209.Count; ++_i210)
                {
                  LegionFightPlayerResponse _elem211 = new LegionFightPlayerResponse();
                  _elem211 = new LegionFightPlayerResponse();
                  _elem211.Read(iprot);
                  Attacker.Add(_elem211);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.List) {
              {
                Target = new List<LegionFightPlayerResponse>();
                TList _list212 = iprot.ReadListBegin();
                for( int _i213 = 0; _i213 < _list212.Count; ++_i213)
                {
                  LegionFightPlayerResponse _elem214 = new LegionFightPlayerResponse();
                  _elem214 = new LegionFightPlayerResponse();
                  _elem214.Read(iprot);
                  Target.Add(_elem214);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.Map) {
              {
                WinningStreakMap = new Dictionary<int, byte>();
                TMap _map215 = iprot.ReadMapBegin();
                for( int _i216 = 0; _i216 < _map215.Count; ++_i216)
                {
                  int _key217;
                  byte _val218;
                  _key217 = iprot.ReadI32();
                  _val218 = iprot.ReadByte();
                  WinningStreakMap[_key217] = _val218;
                }
                iprot.ReadMapEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.Byte) {
              FightListSum = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.List) {
              {
                Actions = new List<LegionFightAction>();
                TList _list219 = iprot.ReadListBegin();
                for( int _i220 = 0; _i220 < _list219.Count; ++_i220)
                {
                  LegionFightAction _elem221 = new LegionFightAction();
                  _elem221 = new LegionFightAction();
                  _elem221.Read(iprot);
                  Actions.Add(_elem221);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.Bool) {
              IsWin = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.Struct) {
              Award = new AwardResponse();
              Award.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.I32) {
              Scene = iprot.ReadI32();
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
      TStruct struc = new TStruct("LegionFightResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.id) {
        field.Name = "id";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Id);
        oprot.WriteFieldEnd();
      }
      if (Attacker != null && __isset.attacker) {
        field.Name = "attacker";
        field.Type = TType.List;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, Attacker.Count));
          foreach (LegionFightPlayerResponse _iter222 in Attacker)
          {
            _iter222.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (Target != null && __isset.target) {
        field.Name = "target";
        field.Type = TType.List;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, Target.Count));
          foreach (LegionFightPlayerResponse _iter223 in Target)
          {
            _iter223.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (WinningStreakMap != null && __isset.winningStreakMap) {
        field.Name = "winningStreakMap";
        field.Type = TType.Map;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.I32, TType.Byte, WinningStreakMap.Count));
          foreach (int _iter224 in WinningStreakMap.Keys)
          {
            oprot.WriteI32(_iter224);
            oprot.WriteByte(WinningStreakMap[_iter224]);
          }
          oprot.WriteMapEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.fightListSum) {
        field.Name = "fightListSum";
        field.Type = TType.Byte;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(FightListSum);
        oprot.WriteFieldEnd();
      }
      if (Actions != null && __isset.actions) {
        field.Name = "actions";
        field.Type = TType.List;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, Actions.Count));
          foreach (LegionFightAction _iter225 in Actions)
          {
            _iter225.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.isWin) {
        field.Name = "isWin";
        field.Type = TType.Bool;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(IsWin);
        oprot.WriteFieldEnd();
      }
      if (Award != null && __isset.award) {
        field.Name = "award";
        field.Type = TType.Struct;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        Award.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (__isset.scene) {
        field.Name = "scene";
        field.Type = TType.I32;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Scene);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("LegionFightResponse(");
      sb.Append("Id: ");
      sb.Append(Id);
      sb.Append(",Attacker: ");
      sb.Append(Attacker);
      sb.Append(",Target: ");
      sb.Append(Target);
      sb.Append(",WinningStreakMap: ");
      sb.Append(WinningStreakMap);
      sb.Append(",FightListSum: ");
      sb.Append(FightListSum);
      sb.Append(",Actions: ");
      sb.Append(Actions);
      sb.Append(",IsWin: ");
      sb.Append(IsWin);
      sb.Append(",Award: ");
      sb.Append(Award== null ? "<null>" : Award.ToString());
      sb.Append(",Scene: ");
      sb.Append(Scene);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
