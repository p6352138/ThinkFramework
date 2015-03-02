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
  public partial class NewPlayerFightResponse : TBase
  {
    private int _id;
    private bool _isSucc;
    private byte _result_type;
    private string _fight_describe;
    private int _attackerLoss;
    private int _targetLoss;
    private Dictionary<byte, FightFriendDataResponse> _attackerFriend;
    private Dictionary<byte, FightFriendDataResponse> _targetFriend;
    private List<FightActionResponse> _fightActionList;
    private string _attackerName;
    private string _targetName;
    private int _scene;
    private bool _isLast;
    private bool _isPass;
    private int _attacker_fighting_capacity;
    private int _target_fighting_capacity;
    private int _general_id;
    private FightArmyAdviserResponse _attacker_ArmyAdviser;
    private FightArmyAdviserResponse _target_ArmyAdviser;
    private Dictionary<byte, int> _attackerArmyAdviserAttributeMap;
    private Dictionary<byte, int> _targetArmyAdviserAttributeMap;
    private int _leader_id;
    private int _fight_time;
    private List<PlayerFightScoreResponse> _defeat_score;
    private QuestionResponse _questionResponse;
    private int _opration_id;
    private List<BorrowGeneralResponse> _borrowGeneralList;
    private NewPlayerFightAwardResponse _award;

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

    public bool IsSucc
    {
      get
      {
        return _isSucc;
      }
      set
      {
        __isset.isSucc = true;
        this._isSucc = value;
      }
    }

    public byte Result_type
    {
      get
      {
        return _result_type;
      }
      set
      {
        __isset.result_type = true;
        this._result_type = value;
      }
    }

    public string Fight_describe
    {
      get
      {
        return _fight_describe;
      }
      set
      {
        __isset.fight_describe = true;
        this._fight_describe = value;
      }
    }

    public int AttackerLoss
    {
      get
      {
        return _attackerLoss;
      }
      set
      {
        __isset.attackerLoss = true;
        this._attackerLoss = value;
      }
    }

    public int TargetLoss
    {
      get
      {
        return _targetLoss;
      }
      set
      {
        __isset.targetLoss = true;
        this._targetLoss = value;
      }
    }

    public Dictionary<byte, FightFriendDataResponse> AttackerFriend
    {
      get
      {
        return _attackerFriend;
      }
      set
      {
        __isset.attackerFriend = true;
        this._attackerFriend = value;
      }
    }

    public Dictionary<byte, FightFriendDataResponse> TargetFriend
    {
      get
      {
        return _targetFriend;
      }
      set
      {
        __isset.targetFriend = true;
        this._targetFriend = value;
      }
    }

    public List<FightActionResponse> FightActionList
    {
      get
      {
        return _fightActionList;
      }
      set
      {
        __isset.fightActionList = true;
        this._fightActionList = value;
      }
    }

    public string AttackerName
    {
      get
      {
        return _attackerName;
      }
      set
      {
        __isset.attackerName = true;
        this._attackerName = value;
      }
    }

    public string TargetName
    {
      get
      {
        return _targetName;
      }
      set
      {
        __isset.targetName = true;
        this._targetName = value;
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

    public bool IsLast
    {
      get
      {
        return _isLast;
      }
      set
      {
        __isset.isLast = true;
        this._isLast = value;
      }
    }

    public bool IsPass
    {
      get
      {
        return _isPass;
      }
      set
      {
        __isset.isPass = true;
        this._isPass = value;
      }
    }

    public int Attacker_fighting_capacity
    {
      get
      {
        return _attacker_fighting_capacity;
      }
      set
      {
        __isset.attacker_fighting_capacity = true;
        this._attacker_fighting_capacity = value;
      }
    }

    public int Target_fighting_capacity
    {
      get
      {
        return _target_fighting_capacity;
      }
      set
      {
        __isset.target_fighting_capacity = true;
        this._target_fighting_capacity = value;
      }
    }

    public int General_id
    {
      get
      {
        return _general_id;
      }
      set
      {
        __isset.general_id = true;
        this._general_id = value;
      }
    }

    public FightArmyAdviserResponse Attacker_ArmyAdviser
    {
      get
      {
        return _attacker_ArmyAdviser;
      }
      set
      {
        __isset.attacker_ArmyAdviser = true;
        this._attacker_ArmyAdviser = value;
      }
    }

    public FightArmyAdviserResponse Target_ArmyAdviser
    {
      get
      {
        return _target_ArmyAdviser;
      }
      set
      {
        __isset.target_ArmyAdviser = true;
        this._target_ArmyAdviser = value;
      }
    }

    public Dictionary<byte, int> AttackerArmyAdviserAttributeMap
    {
      get
      {
        return _attackerArmyAdviserAttributeMap;
      }
      set
      {
        __isset.attackerArmyAdviserAttributeMap = true;
        this._attackerArmyAdviserAttributeMap = value;
      }
    }

    public Dictionary<byte, int> TargetArmyAdviserAttributeMap
    {
      get
      {
        return _targetArmyAdviserAttributeMap;
      }
      set
      {
        __isset.targetArmyAdviserAttributeMap = true;
        this._targetArmyAdviserAttributeMap = value;
      }
    }

    public int Leader_id
    {
      get
      {
        return _leader_id;
      }
      set
      {
        __isset.leader_id = true;
        this._leader_id = value;
      }
    }

    public int Fight_time
    {
      get
      {
        return _fight_time;
      }
      set
      {
        __isset.fight_time = true;
        this._fight_time = value;
      }
    }

    public List<PlayerFightScoreResponse> Defeat_score
    {
      get
      {
        return _defeat_score;
      }
      set
      {
        __isset.defeat_score = true;
        this._defeat_score = value;
      }
    }

    public QuestionResponse QuestionResponse
    {
      get
      {
        return _questionResponse;
      }
      set
      {
        __isset.questionResponse = true;
        this._questionResponse = value;
      }
    }

    public int Opration_id
    {
      get
      {
        return _opration_id;
      }
      set
      {
        __isset.opration_id = true;
        this._opration_id = value;
      }
    }

    public List<BorrowGeneralResponse> BorrowGeneralList
    {
      get
      {
        return _borrowGeneralList;
      }
      set
      {
        __isset.borrowGeneralList = true;
        this._borrowGeneralList = value;
      }
    }

    public NewPlayerFightAwardResponse Award
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


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool id;
      public bool isSucc;
      public bool result_type;
      public bool fight_describe;
      public bool attackerLoss;
      public bool targetLoss;
      public bool attackerFriend;
      public bool targetFriend;
      public bool fightActionList;
      public bool attackerName;
      public bool targetName;
      public bool scene;
      public bool isLast;
      public bool isPass;
      public bool attacker_fighting_capacity;
      public bool target_fighting_capacity;
      public bool general_id;
      public bool attacker_ArmyAdviser;
      public bool target_ArmyAdviser;
      public bool attackerArmyAdviserAttributeMap;
      public bool targetArmyAdviserAttributeMap;
      public bool leader_id;
      public bool fight_time;
      public bool defeat_score;
      public bool questionResponse;
      public bool opration_id;
      public bool borrowGeneralList;
      public bool award;
    }

    public NewPlayerFightResponse() {
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
            if (field.Type == TType.Bool) {
              IsSucc = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Byte) {
              Result_type = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.String) {
              Fight_describe = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              AttackerLoss = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I32) {
              TargetLoss = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.Map) {
              {
                AttackerFriend = new Dictionary<byte, FightFriendDataResponse>();
                TMap _map617 = iprot.ReadMapBegin();
                for( int _i618 = 0; _i618 < _map617.Count; ++_i618)
                {
                  byte _key619;
                  FightFriendDataResponse _val620;
                  _key619 = iprot.ReadByte();
                  _val620 = new FightFriendDataResponse();
                  _val620.Read(iprot);
                  AttackerFriend[_key619] = _val620;
                }
                iprot.ReadMapEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.Map) {
              {
                TargetFriend = new Dictionary<byte, FightFriendDataResponse>();
                TMap _map621 = iprot.ReadMapBegin();
                for( int _i622 = 0; _i622 < _map621.Count; ++_i622)
                {
                  byte _key623;
                  FightFriendDataResponse _val624;
                  _key623 = iprot.ReadByte();
                  _val624 = new FightFriendDataResponse();
                  _val624.Read(iprot);
                  TargetFriend[_key623] = _val624;
                }
                iprot.ReadMapEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.List) {
              {
                FightActionList = new List<FightActionResponse>();
                TList _list625 = iprot.ReadListBegin();
                for( int _i626 = 0; _i626 < _list625.Count; ++_i626)
                {
                  FightActionResponse _elem627 = new FightActionResponse();
                  _elem627 = new FightActionResponse();
                  _elem627.Read(iprot);
                  FightActionList.Add(_elem627);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.String) {
              AttackerName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.String) {
              TargetName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 12:
            if (field.Type == TType.I32) {
              Scene = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 13:
            if (field.Type == TType.Bool) {
              IsLast = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 14:
            if (field.Type == TType.Bool) {
              IsPass = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 15:
            if (field.Type == TType.I32) {
              Attacker_fighting_capacity = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 16:
            if (field.Type == TType.I32) {
              Target_fighting_capacity = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 17:
            if (field.Type == TType.I32) {
              General_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 18:
            if (field.Type == TType.Struct) {
              Attacker_ArmyAdviser = new FightArmyAdviserResponse();
              Attacker_ArmyAdviser.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 19:
            if (field.Type == TType.Struct) {
              Target_ArmyAdviser = new FightArmyAdviserResponse();
              Target_ArmyAdviser.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 20:
            if (field.Type == TType.Map) {
              {
                AttackerArmyAdviserAttributeMap = new Dictionary<byte, int>();
                TMap _map628 = iprot.ReadMapBegin();
                for( int _i629 = 0; _i629 < _map628.Count; ++_i629)
                {
                  byte _key630;
                  int _val631;
                  _key630 = iprot.ReadByte();
                  _val631 = iprot.ReadI32();
                  AttackerArmyAdviserAttributeMap[_key630] = _val631;
                }
                iprot.ReadMapEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 21:
            if (field.Type == TType.Map) {
              {
                TargetArmyAdviserAttributeMap = new Dictionary<byte, int>();
                TMap _map632 = iprot.ReadMapBegin();
                for( int _i633 = 0; _i633 < _map632.Count; ++_i633)
                {
                  byte _key634;
                  int _val635;
                  _key634 = iprot.ReadByte();
                  _val635 = iprot.ReadI32();
                  TargetArmyAdviserAttributeMap[_key634] = _val635;
                }
                iprot.ReadMapEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 22:
            if (field.Type == TType.I32) {
              Leader_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 23:
            if (field.Type == TType.I32) {
              Fight_time = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 24:
            if (field.Type == TType.List) {
              {
                Defeat_score = new List<PlayerFightScoreResponse>();
                TList _list636 = iprot.ReadListBegin();
                for( int _i637 = 0; _i637 < _list636.Count; ++_i637)
                {
                  PlayerFightScoreResponse _elem638 = new PlayerFightScoreResponse();
                  _elem638 = new PlayerFightScoreResponse();
                  _elem638.Read(iprot);
                  Defeat_score.Add(_elem638);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 25:
            if (field.Type == TType.Struct) {
              QuestionResponse = new QuestionResponse();
              QuestionResponse.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 26:
            if (field.Type == TType.I32) {
              Opration_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 27:
            if (field.Type == TType.List) {
              {
                BorrowGeneralList = new List<BorrowGeneralResponse>();
                TList _list639 = iprot.ReadListBegin();
                for( int _i640 = 0; _i640 < _list639.Count; ++_i640)
                {
                  BorrowGeneralResponse _elem641 = new BorrowGeneralResponse();
                  _elem641 = new BorrowGeneralResponse();
                  _elem641.Read(iprot);
                  BorrowGeneralList.Add(_elem641);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 28:
            if (field.Type == TType.Struct) {
              Award = new NewPlayerFightAwardResponse();
              Award.Read(iprot);
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
      TStruct struc = new TStruct("NewPlayerFightResponse");
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
      if (__isset.isSucc) {
        field.Name = "isSucc";
        field.Type = TType.Bool;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(IsSucc);
        oprot.WriteFieldEnd();
      }
      if (__isset.result_type) {
        field.Name = "result_type";
        field.Type = TType.Byte;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Result_type);
        oprot.WriteFieldEnd();
      }
      if (Fight_describe != null && __isset.fight_describe) {
        field.Name = "fight_describe";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Fight_describe);
        oprot.WriteFieldEnd();
      }
      if (__isset.attackerLoss) {
        field.Name = "attackerLoss";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(AttackerLoss);
        oprot.WriteFieldEnd();
      }
      if (__isset.targetLoss) {
        field.Name = "targetLoss";
        field.Type = TType.I32;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(TargetLoss);
        oprot.WriteFieldEnd();
      }
      if (AttackerFriend != null && __isset.attackerFriend) {
        field.Name = "attackerFriend";
        field.Type = TType.Map;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.Byte, TType.Struct, AttackerFriend.Count));
          foreach (byte _iter642 in AttackerFriend.Keys)
          {
            oprot.WriteByte(_iter642);
            AttackerFriend[_iter642].Write(oprot);
          }
          oprot.WriteMapEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (TargetFriend != null && __isset.targetFriend) {
        field.Name = "targetFriend";
        field.Type = TType.Map;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.Byte, TType.Struct, TargetFriend.Count));
          foreach (byte _iter643 in TargetFriend.Keys)
          {
            oprot.WriteByte(_iter643);
            TargetFriend[_iter643].Write(oprot);
          }
          oprot.WriteMapEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (FightActionList != null && __isset.fightActionList) {
        field.Name = "fightActionList";
        field.Type = TType.List;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, FightActionList.Count));
          foreach (FightActionResponse _iter644 in FightActionList)
          {
            _iter644.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (AttackerName != null && __isset.attackerName) {
        field.Name = "attackerName";
        field.Type = TType.String;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(AttackerName);
        oprot.WriteFieldEnd();
      }
      if (TargetName != null && __isset.targetName) {
        field.Name = "targetName";
        field.Type = TType.String;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(TargetName);
        oprot.WriteFieldEnd();
      }
      if (__isset.scene) {
        field.Name = "scene";
        field.Type = TType.I32;
        field.ID = 12;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Scene);
        oprot.WriteFieldEnd();
      }
      if (__isset.isLast) {
        field.Name = "isLast";
        field.Type = TType.Bool;
        field.ID = 13;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(IsLast);
        oprot.WriteFieldEnd();
      }
      if (__isset.isPass) {
        field.Name = "isPass";
        field.Type = TType.Bool;
        field.ID = 14;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(IsPass);
        oprot.WriteFieldEnd();
      }
      if (__isset.attacker_fighting_capacity) {
        field.Name = "attacker_fighting_capacity";
        field.Type = TType.I32;
        field.ID = 15;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Attacker_fighting_capacity);
        oprot.WriteFieldEnd();
      }
      if (__isset.target_fighting_capacity) {
        field.Name = "target_fighting_capacity";
        field.Type = TType.I32;
        field.ID = 16;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Target_fighting_capacity);
        oprot.WriteFieldEnd();
      }
      if (__isset.general_id) {
        field.Name = "general_id";
        field.Type = TType.I32;
        field.ID = 17;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(General_id);
        oprot.WriteFieldEnd();
      }
      if (Attacker_ArmyAdviser != null && __isset.attacker_ArmyAdviser) {
        field.Name = "attacker_ArmyAdviser";
        field.Type = TType.Struct;
        field.ID = 18;
        oprot.WriteFieldBegin(field);
        Attacker_ArmyAdviser.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (Target_ArmyAdviser != null && __isset.target_ArmyAdviser) {
        field.Name = "target_ArmyAdviser";
        field.Type = TType.Struct;
        field.ID = 19;
        oprot.WriteFieldBegin(field);
        Target_ArmyAdviser.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (AttackerArmyAdviserAttributeMap != null && __isset.attackerArmyAdviserAttributeMap) {
        field.Name = "attackerArmyAdviserAttributeMap";
        field.Type = TType.Map;
        field.ID = 20;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.Byte, TType.I32, AttackerArmyAdviserAttributeMap.Count));
          foreach (byte _iter645 in AttackerArmyAdviserAttributeMap.Keys)
          {
            oprot.WriteByte(_iter645);
            oprot.WriteI32(AttackerArmyAdviserAttributeMap[_iter645]);
          }
          oprot.WriteMapEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (TargetArmyAdviserAttributeMap != null && __isset.targetArmyAdviserAttributeMap) {
        field.Name = "targetArmyAdviserAttributeMap";
        field.Type = TType.Map;
        field.ID = 21;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.Byte, TType.I32, TargetArmyAdviserAttributeMap.Count));
          foreach (byte _iter646 in TargetArmyAdviserAttributeMap.Keys)
          {
            oprot.WriteByte(_iter646);
            oprot.WriteI32(TargetArmyAdviserAttributeMap[_iter646]);
          }
          oprot.WriteMapEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.leader_id) {
        field.Name = "leader_id";
        field.Type = TType.I32;
        field.ID = 22;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Leader_id);
        oprot.WriteFieldEnd();
      }
      if (__isset.fight_time) {
        field.Name = "fight_time";
        field.Type = TType.I32;
        field.ID = 23;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Fight_time);
        oprot.WriteFieldEnd();
      }
      if (Defeat_score != null && __isset.defeat_score) {
        field.Name = "defeat_score";
        field.Type = TType.List;
        field.ID = 24;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, Defeat_score.Count));
          foreach (PlayerFightScoreResponse _iter647 in Defeat_score)
          {
            _iter647.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (QuestionResponse != null && __isset.questionResponse) {
        field.Name = "questionResponse";
        field.Type = TType.Struct;
        field.ID = 25;
        oprot.WriteFieldBegin(field);
        QuestionResponse.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (__isset.opration_id) {
        field.Name = "opration_id";
        field.Type = TType.I32;
        field.ID = 26;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Opration_id);
        oprot.WriteFieldEnd();
      }
      if (BorrowGeneralList != null && __isset.borrowGeneralList) {
        field.Name = "borrowGeneralList";
        field.Type = TType.List;
        field.ID = 27;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, BorrowGeneralList.Count));
          foreach (BorrowGeneralResponse _iter648 in BorrowGeneralList)
          {
            _iter648.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (Award != null && __isset.award) {
        field.Name = "award";
        field.Type = TType.Struct;
        field.ID = 28;
        oprot.WriteFieldBegin(field);
        Award.Write(oprot);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("NewPlayerFightResponse(");
      sb.Append("Id: ");
      sb.Append(Id);
      sb.Append(",IsSucc: ");
      sb.Append(IsSucc);
      sb.Append(",Result_type: ");
      sb.Append(Result_type);
      sb.Append(",Fight_describe: ");
      sb.Append(Fight_describe);
      sb.Append(",AttackerLoss: ");
      sb.Append(AttackerLoss);
      sb.Append(",TargetLoss: ");
      sb.Append(TargetLoss);
      sb.Append(",AttackerFriend: ");
      sb.Append(AttackerFriend);
      sb.Append(",TargetFriend: ");
      sb.Append(TargetFriend);
      sb.Append(",FightActionList: ");
      sb.Append(FightActionList);
      sb.Append(",AttackerName: ");
      sb.Append(AttackerName);
      sb.Append(",TargetName: ");
      sb.Append(TargetName);
      sb.Append(",Scene: ");
      sb.Append(Scene);
      sb.Append(",IsLast: ");
      sb.Append(IsLast);
      sb.Append(",IsPass: ");
      sb.Append(IsPass);
      sb.Append(",Attacker_fighting_capacity: ");
      sb.Append(Attacker_fighting_capacity);
      sb.Append(",Target_fighting_capacity: ");
      sb.Append(Target_fighting_capacity);
      sb.Append(",General_id: ");
      sb.Append(General_id);
      sb.Append(",Attacker_ArmyAdviser: ");
      sb.Append(Attacker_ArmyAdviser== null ? "<null>" : Attacker_ArmyAdviser.ToString());
      sb.Append(",Target_ArmyAdviser: ");
      sb.Append(Target_ArmyAdviser== null ? "<null>" : Target_ArmyAdviser.ToString());
      sb.Append(",AttackerArmyAdviserAttributeMap: ");
      sb.Append(AttackerArmyAdviserAttributeMap);
      sb.Append(",TargetArmyAdviserAttributeMap: ");
      sb.Append(TargetArmyAdviserAttributeMap);
      sb.Append(",Leader_id: ");
      sb.Append(Leader_id);
      sb.Append(",Fight_time: ");
      sb.Append(Fight_time);
      sb.Append(",Defeat_score: ");
      sb.Append(Defeat_score);
      sb.Append(",QuestionResponse: ");
      sb.Append(QuestionResponse== null ? "<null>" : QuestionResponse.ToString());
      sb.Append(",Opration_id: ");
      sb.Append(Opration_id);
      sb.Append(",BorrowGeneralList: ");
      sb.Append(BorrowGeneralList);
      sb.Append(",Award: ");
      sb.Append(Award== null ? "<null>" : Award.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }

}