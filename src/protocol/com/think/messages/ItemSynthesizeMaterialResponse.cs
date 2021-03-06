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
  public partial class ItemSynthesizeMaterialResponse : TBase
  {
    private int _instanceID;
    private List<MaterialResponse> _materialList;
    private Dictionary<byte, int> _attributeMap;
    private string _intensifyLvl;
    private string _goodsName;
    private byte _trait;
    private int _icon;
    private int _intensifyLevel;

    public int InstanceID
    {
      get
      {
        return _instanceID;
      }
      set
      {
        __isset.instanceID = true;
        this._instanceID = value;
      }
    }

    public List<MaterialResponse> MaterialList
    {
      get
      {
        return _materialList;
      }
      set
      {
        __isset.materialList = true;
        this._materialList = value;
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

    public string IntensifyLvl
    {
      get
      {
        return _intensifyLvl;
      }
      set
      {
        __isset.intensifyLvl = true;
        this._intensifyLvl = value;
      }
    }

    public string GoodsName
    {
      get
      {
        return _goodsName;
      }
      set
      {
        __isset.goodsName = true;
        this._goodsName = value;
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

    public int Icon
    {
      get
      {
        return _icon;
      }
      set
      {
        __isset.icon = true;
        this._icon = value;
      }
    }

    public int IntensifyLevel
    {
      get
      {
        return _intensifyLevel;
      }
      set
      {
        __isset.intensifyLevel = true;
        this._intensifyLevel = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool instanceID;
      public bool materialList;
      public bool attributeMap;
      public bool intensifyLvl;
      public bool goodsName;
      public bool trait;
      public bool icon;
      public bool intensifyLevel;
    }

    public ItemSynthesizeMaterialResponse() {
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
              InstanceID = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.List) {
              {
                MaterialList = new List<MaterialResponse>();
                TList _list12 = iprot.ReadListBegin();
                for( int _i13 = 0; _i13 < _list12.Count; ++_i13)
                {
                  MaterialResponse _elem14 = new MaterialResponse();
                  _elem14 = new MaterialResponse();
                  _elem14.Read(iprot);
                  MaterialList.Add(_elem14);
                }
                iprot.ReadListEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Map) {
              {
                AttributeMap = new Dictionary<byte, int>();
                TMap _map15 = iprot.ReadMapBegin();
                for( int _i16 = 0; _i16 < _map15.Count; ++_i16)
                {
                  byte _key17;
                  int _val18;
                  _key17 = iprot.ReadByte();
                  _val18 = iprot.ReadI32();
                  AttributeMap[_key17] = _val18;
                }
                iprot.ReadMapEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.String) {
              IntensifyLvl = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.String) {
              GoodsName = iprot.ReadString();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.Byte) {
              Trait = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.I32) {
              Icon = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.I32) {
              IntensifyLevel = iprot.ReadI32();
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
      TStruct struc = new TStruct("ItemSynthesizeMaterialResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.instanceID) {
        field.Name = "instanceID";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(InstanceID);
        oprot.WriteFieldEnd();
      }
      if (MaterialList != null && __isset.materialList) {
        field.Name = "materialList";
        field.Type = TType.List;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, MaterialList.Count));
          foreach (MaterialResponse _iter19 in MaterialList)
          {
            _iter19.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (AttributeMap != null && __isset.attributeMap) {
        field.Name = "attributeMap";
        field.Type = TType.Map;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.Byte, TType.I32, AttributeMap.Count));
          foreach (byte _iter20 in AttributeMap.Keys)
          {
            oprot.WriteByte(_iter20);
            oprot.WriteI32(AttributeMap[_iter20]);
          }
          oprot.WriteMapEnd();
        }
        oprot.WriteFieldEnd();
      }
      if (IntensifyLvl != null && __isset.intensifyLvl) {
        field.Name = "intensifyLvl";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(IntensifyLvl);
        oprot.WriteFieldEnd();
      }
      if (GoodsName != null && __isset.goodsName) {
        field.Name = "goodsName";
        field.Type = TType.String;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(GoodsName);
        oprot.WriteFieldEnd();
      }
      if (__isset.trait) {
        field.Name = "trait";
        field.Type = TType.Byte;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Trait);
        oprot.WriteFieldEnd();
      }
      if (__isset.icon) {
        field.Name = "icon";
        field.Type = TType.I32;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Icon);
        oprot.WriteFieldEnd();
      }
      if (__isset.intensifyLevel) {
        field.Name = "intensifyLevel";
        field.Type = TType.I32;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(IntensifyLevel);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ItemSynthesizeMaterialResponse(");
      sb.Append("InstanceID: ");
      sb.Append(InstanceID);
      sb.Append(",MaterialList: ");
      sb.Append(MaterialList);
      sb.Append(",AttributeMap: ");
      sb.Append(AttributeMap);
      sb.Append(",IntensifyLvl: ");
      sb.Append(IntensifyLvl);
      sb.Append(",GoodsName: ");
      sb.Append(GoodsName);
      sb.Append(",Trait: ");
      sb.Append(Trait);
      sb.Append(",Icon: ");
      sb.Append(Icon);
      sb.Append(",IntensifyLevel: ");
      sb.Append(IntensifyLevel);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
