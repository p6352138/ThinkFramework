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
  public partial class PlayerBagResponse : TBase
  {
    private int _size;
    private List<BagResponse> _playerBag;

    public int Size
    {
      get
      {
        return _size;
      }
      set
      {
        __isset.size = true;
        this._size = value;
      }
    }

    public List<BagResponse> PlayerBag
    {
      get
      {
        return _playerBag;
      }
      set
      {
        __isset.playerBag = true;
        this._playerBag = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool size;
      public bool playerBag;
    }

    public PlayerBagResponse() {
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
              Size = iprot.ReadI32();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.List) {
              {
                PlayerBag = new List<BagResponse>();
                TList _list64 = iprot.ReadListBegin();
                for( int _i65 = 0; _i65 < _list64.Count; ++_i65)
                {
                  BagResponse _elem66 = new BagResponse();
                  _elem66 = new BagResponse();
                  _elem66.Read(iprot);
                  PlayerBag.Add(_elem66);
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
      TStruct struc = new TStruct("PlayerBagResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.size) {
        field.Name = "size";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(Size);
        oprot.WriteFieldEnd();
      }
      if (PlayerBag != null && __isset.playerBag) {
        field.Name = "playerBag";
        field.Type = TType.List;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, PlayerBag.Count));
          foreach (BagResponse _iter67 in PlayerBag)
          {
            _iter67.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("PlayerBagResponse(");
      sb.Append("Size: ");
      sb.Append(Size);
      sb.Append(",PlayerBag: ");
      sb.Append(PlayerBag);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
