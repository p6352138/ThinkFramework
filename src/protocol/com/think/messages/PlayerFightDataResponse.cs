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
  public partial class PlayerFightDataResponse : TBase
  {
    private Dictionary<byte, FightFriendDataResponse> _generalMap;

    public Dictionary<byte, FightFriendDataResponse> GeneralMap
    {
      get
      {
        return _generalMap;
      }
      set
      {
        __isset.generalMap = true;
        this._generalMap = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool generalMap;
    }

    public PlayerFightDataResponse() {
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
            if (field.Type == TType.Map) {
              {
                GeneralMap = new Dictionary<byte, FightFriendDataResponse>();
                TMap _map694 = iprot.ReadMapBegin();
                for( int _i695 = 0; _i695 < _map694.Count; ++_i695)
                {
                  byte _key696;
                  FightFriendDataResponse _val697;
                  _key696 = iprot.ReadByte();
                  _val697 = new FightFriendDataResponse();
                  _val697.Read(iprot);
                  GeneralMap[_key696] = _val697;
                }
                iprot.ReadMapEnd();
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
      TStruct struc = new TStruct("PlayerFightDataResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (GeneralMap != null && __isset.generalMap) {
        field.Name = "generalMap";
        field.Type = TType.Map;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.Byte, TType.Struct, GeneralMap.Count));
          foreach (byte _iter698 in GeneralMap.Keys)
          {
            oprot.WriteByte(_iter698);
            GeneralMap[_iter698].Write(oprot);
          }
          oprot.WriteMapEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("PlayerFightDataResponse(");
      sb.Append("GeneralMap: ");
      sb.Append(GeneralMap);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
