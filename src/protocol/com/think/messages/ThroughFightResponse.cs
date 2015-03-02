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
  public partial class ThroughFightResponse : TBase
  {
    private int _general_id;
    private int _exploit;
    private int _itemID;
    private byte _trait;
    private int _itemImage;
    private string _itemName;
    private int _money;
    private int _fragment;
    private ThroughDungeonGeneralResponse _throughDungeonGeneralResponse;

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

    public ThroughDungeonGeneralResponse ThroughDungeonGeneralResponse
    {
      get
      {
        return _throughDungeonGeneralResponse;
      }
      set
      {
        __isset.throughDungeonGeneralResponse = true;
        this._throughDungeonGeneralResponse = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool general_id;
      public bool exploit;
      public bool itemID;
      public bool trait;
      public bool itemImage;
      public bool itemName;
      public bool money;
      public bool fragment;
      public bool throughDungeonGeneralResponse;
    }

    public ThroughFightResponse() {
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
              General_id = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              Exploit = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              ItemID = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.Byte) {
              Trait = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              ItemImage = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.String) {
              ItemName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.I32) {
              Money = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.I32) {
              Fragment = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.Struct) {
              ThroughDungeonGeneralResponse = new ThroughDungeonGeneralResponse();
              ThroughDungeonGeneralResponse.Read(iprot);
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
      TStruct struc = new TStruct("ThroughFightResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.general_id) {
        field.Name = "general_id";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(General_id);
        oprot.WriteFieldEnd();
      }
      if (__isset.exploit) {
        field.Name = "exploit";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Exploit);
        oprot.WriteFieldEnd();
      }
      if (__isset.itemID) {
        field.Name = "itemID";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(ItemID);
        oprot.WriteFieldEnd();
      }
      if (__isset.trait) {
        field.Name = "trait";
        field.Type = TType.Byte;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Trait);
        oprot.WriteFieldEnd();
      }
      if (__isset.itemImage) {
        field.Name = "itemImage";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(ItemImage);
        oprot.WriteFieldEnd();
      }
      if (ItemName != null && __isset.itemName) {
        field.Name = "itemName";
        field.Type = TType.String;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(ItemName);
        oprot.WriteFieldEnd();
      }
      if (__isset.money) {
        field.Name = "money";
        field.Type = TType.I32;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Money);
        oprot.WriteFieldEnd();
      }
      if (__isset.fragment) {
        field.Name = "fragment";
        field.Type = TType.I32;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Fragment);
        oprot.WriteFieldEnd();
      }
      if (ThroughDungeonGeneralResponse != null && __isset.throughDungeonGeneralResponse) {
        field.Name = "throughDungeonGeneralResponse";
        field.Type = TType.Struct;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        ThroughDungeonGeneralResponse.Write(oprot);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ThroughFightResponse(");
      sb.Append("General_id: ");
      sb.Append(General_id);
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
      sb.Append(",Money: ");
      sb.Append(Money);
      sb.Append(",Fragment: ");
      sb.Append(Fragment);
      sb.Append(",ThroughDungeonGeneralResponse: ");
      sb.Append(ThroughDungeonGeneralResponse== null ? "<null>" : ThroughDungeonGeneralResponse.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }

}
