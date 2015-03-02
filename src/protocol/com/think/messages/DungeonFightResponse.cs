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
  public partial class DungeonFightResponse : TBase
  {
    private bool _isSucc;
    private byte _result_type;
    private string _fight_describe;
    private int _attackerLoss;
    private int _targetLoss;
    private string _attackerName;
    private string _targetName;
    private int _id;
    private int _exploit;
    private int _itemID;
    private byte _trait;
    private int _itemImage;
    private string _itemName;
    private int _scene;
    private int _money;
    private int _fragment;
    private int _exp;
    private List<ResourceResponse> _listAward;

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

    public int Exploit
    {
      get
      {
        return _exploit;
      }
      set
      {
        __isset.exploit = true;
        this._exploit = value;
      }
    }

    public int ItemID
    {
      get
      {
        return _itemID;
      }
      set
      {
        __isset.itemID = true;
        this._itemID = value;
      }
    }

    public byte Trait
    {
      get
      {
        return _trait;
      }
      set
      {
        __isset.trait = true;
        this._trait = value;
      }
    }

    public int ItemImage
    {
      get
      {
        return _itemImage;
      }
      set
      {
        __isset.itemImage = true;
        this._itemImage = value;
      }
    }

    public string ItemName
    {
      get
      {
        return _itemName;
      }
      set
      {
        __isset.itemName = true;
        this._itemName = value;
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

    public int Money
    {
      get
      {
        return _money;
      }
      set
      {
        __isset.money = true;
        this._money = value;
      }
    }

    public int Fragment
    {
      get
      {
        return _fragment;
      }
      set
      {
        __isset.fragment = true;
        this._fragment = value;
      }
    }

    public int Exp
    {
      get
      {
        return _exp;
      }
      set
      {
        __isset.exp = true;
        this._exp = value;
      }
    }

    public List<ResourceResponse> ListAward
    {
      get
      {
        return _listAward;
      }
      set
      {
        __isset.listAward = true;
        this._listAward = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool isSucc;
      public bool result_type;
      public bool fight_describe;
      public bool attackerLoss;
      public bool targetLoss;
      public bool attackerName;
      public bool targetName;
      public bool id;
      public bool exploit;
      public bool itemID;
      public bool trait;
      public bool itemImage;
      public bool itemName;
      public bool scene;
      public bool money;
      public bool fragment;
      public bool exp;
      public bool listAward;
    }

    public DungeonFightResponse() {
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
            if (field.Type == TType.Bool) {
              IsSucc = iprot.ReadBool();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Byte) {
              Result_type = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              Fight_describe = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              AttackerLoss = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              TargetLoss = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.String) {
              AttackerName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.String) {
              TargetName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.I32) {
              Id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.I32) {
              Exploit = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.I32) {
              ItemID = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.Byte) {
              Trait = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 12:
            if (field.Type == TType.I32) {
              ItemImage = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 13:
            if (field.Type == TType.String) {
              ItemName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 14:
            if (field.Type == TType.I32) {
              Scene = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 15:
            if (field.Type == TType.I32) {
              Money = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 16:
            if (field.Type == TType.I32) {
              Fragment = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 17:
            if (field.Type == TType.I32) {
              Exp = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 18:
            if (field.Type == TType.List) {
              {
                ListAward = new List<ResourceResponse>();
                TList _list197 = iprot.ReadListBegin();
                for( int _i198 = 0; _i198 < _list197.Count; ++_i198)
                {
                  ResourceResponse _elem199 = new ResourceResponse();
                  _elem199 = new ResourceResponse();
                  _elem199.Read(iprot);
                  ListAward.Add(_elem199);
                }
                iprot.ReadListEnd();
              }
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
      TStruct struc = new TStruct("DungeonFightResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.isSucc) {
        field.Name = "isSucc";
        field.Type = TType.Bool;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(IsSucc);
        oprot.WriteFieldEnd();
      }
      if (__isset.result_type) {
        field.Name = "result_type";
        field.Type = TType.Byte;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Result_type);
        oprot.WriteFieldEnd();
      }
      if (Fight_describe != null && __isset.fight_describe) {
        field.Name = "fight_describe";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(Fight_describe);
        oprot.WriteFieldEnd();
      }
      if (__isset.attackerLoss) {
        field.Name = "attackerLoss";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(AttackerLoss);
        oprot.WriteFieldEnd();
      }
      if (__isset.targetLoss) {
        field.Name = "targetLoss";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(TargetLoss);
        oprot.WriteFieldEnd();
      }
      if (AttackerName != null && __isset.attackerName) {
        field.Name = "attackerName";
        field.Type = TType.String;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(AttackerName);
        oprot.WriteFieldEnd();
      }
      if (TargetName != null && __isset.targetName) {
        field.Name = "targetName";
        field.Type = TType.String;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(TargetName);
        oprot.WriteFieldEnd();
      }
      if (__isset.id) {
        field.Name = "id";
        field.Type = TType.I32;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Id);
        oprot.WriteFieldEnd();
      }
      if (__isset.exploit) {
        field.Name = "exploit";
        field.Type = TType.I32;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Exploit);
        oprot.WriteFieldEnd();
      }
      if (__isset.itemID) {
        field.Name = "itemID";
        field.Type = TType.I32;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(ItemID);
        oprot.WriteFieldEnd();
      }
      if (__isset.trait) {
        field.Name = "trait";
        field.Type = TType.Byte;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Trait);
        oprot.WriteFieldEnd();
      }
      if (__isset.itemImage) {
        field.Name = "itemImage";
        field.Type = TType.I32;
        field.ID = 12;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(ItemImage);
        oprot.WriteFieldEnd();
      }
      if (ItemName != null && __isset.itemName) {
        field.Name = "itemName";
        field.Type = TType.String;
        field.ID = 13;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(ItemName);
        oprot.WriteFieldEnd();
      }
      if (__isset.scene) {
        field.Name = "scene";
        field.Type = TType.I32;
        field.ID = 14;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Scene);
        oprot.WriteFieldEnd();
      }
      if (__isset.money) {
        field.Name = "money";
        field.Type = TType.I32;
        field.ID = 15;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Money);
        oprot.WriteFieldEnd();
      }
      if (__isset.fragment) {
        field.Name = "fragment";
        field.Type = TType.I32;
        field.ID = 16;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Fragment);
        oprot.WriteFieldEnd();
      }
      if (__isset.exp) {
        field.Name = "exp";
        field.Type = TType.I32;
        field.ID = 17;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Exp);
        oprot.WriteFieldEnd();
      }
      if (ListAward != null && __isset.listAward) {
        field.Name = "listAward";
        field.Type = TType.List;
        field.ID = 18;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, ListAward.Count));
          foreach (ResourceResponse _iter200 in ListAward)
          {
            _iter200.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("DungeonFightResponse(");
      sb.Append("IsSucc: ");
      sb.Append(IsSucc);
      sb.Append(",Result_type: ");
      sb.Append(Result_type);
      sb.Append(",Fight_describe: ");
      sb.Append(Fight_describe);
      sb.Append(",AttackerLoss: ");
      sb.Append(AttackerLoss);
      sb.Append(",TargetLoss: ");
      sb.Append(TargetLoss);
      sb.Append(",AttackerName: ");
      sb.Append(AttackerName);
      sb.Append(",TargetName: ");
      sb.Append(TargetName);
      sb.Append(",Id: ");
      sb.Append(Id);
      sb.Append(",Exploit: ");
      sb.Append(Exploit);
      sb.Append(",ItemID: ");
      sb.Append(ItemID);
      sb.Append(",Trait: ");
      sb.Append(Trait);
      sb.Append(",ItemImage: ");
      sb.Append(ItemImage);
      sb.Append(",ItemName: ");
      sb.Append(ItemName);
      sb.Append(",Scene: ");
      sb.Append(Scene);
      sb.Append(",Money: ");
      sb.Append(Money);
      sb.Append(",Fragment: ");
      sb.Append(Fragment);
      sb.Append(",Exp: ");
      sb.Append(Exp);
      sb.Append(",ListAward: ");
      sb.Append(ListAward);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
