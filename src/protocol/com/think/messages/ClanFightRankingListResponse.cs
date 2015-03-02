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
  public partial class ClanFightRankingListResponse : TBase
  {
    private byte _type;
    private List<ClanFightRankingResponse> _playerList;

    public byte Type
    {
      get
      {
        return _type;
      }
      set
      {
        __isset.type = true;
        this._type = value;
      }
    }

    public List<ClanFightRankingResponse> PlayerList
    {
      get
      {
        return _playerList;
      }
      set
      {
        __isset.playerList = true;
        this._playerList = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool type;
      public bool playerList;
    }

    public ClanFightRankingListResponse() {
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
              Type = iprot.ReadByte();
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.List) {
              {
                PlayerList = new List<ClanFightRankingResponse>();
                TList _list837 = iprot.ReadListBegin();
                for( int _i838 = 0; _i838 < _list837.Count; ++_i838)
                {
                  ClanFightRankingResponse _elem839 = new ClanFightRankingResponse();
                  _elem839 = new ClanFightRankingResponse();
                  _elem839.Read(iprot);
                  PlayerList.Add(_elem839);
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
      TStruct struc = new TStruct("ClanFightRankingListResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.type) {
        field.Name = "type";
        field.Type = TType.Byte;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteByte(Type);
        oprot.WriteFieldEnd();
      }
      if (PlayerList != null && __isset.playerList) {
        field.Name = "playerList";
        field.Type = TType.List;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, PlayerList.Count));
          foreach (ClanFightRankingResponse _iter840 in PlayerList)
          {
            _iter840.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ClanFightRankingListResponse(");
      sb.Append("Type: ");
      sb.Append(Type);
      sb.Append(",PlayerList: ");
      sb.Append(PlayerList);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
