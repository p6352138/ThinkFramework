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
  public partial class ListPlayerBossFightResponse : TBase
  {
    private List<PlayerBossFightResponse> _bossPlayer;

    public List<PlayerBossFightResponse> BossPlayer
    {
      get
      {
        return _bossPlayer;
      }
      set
      {
        __isset.bossPlayer = true;
        this._bossPlayer = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool bossPlayer;
    }

    public ListPlayerBossFightResponse() {
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
            if (field.Type == TType.List) {
              {
                BossPlayer = new List<PlayerBossFightResponse>();
                TList _list378 = iprot.ReadListBegin();
                for( int _i379 = 0; _i379 < _list378.Count; ++_i379)
                {
                  PlayerBossFightResponse _elem380 = new PlayerBossFightResponse();
                  _elem380 = new PlayerBossFightResponse();
                  _elem380.Read(iprot);
                  BossPlayer.Add(_elem380);
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
      TStruct struc = new TStruct("ListPlayerBossFightResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (BossPlayer != null && __isset.bossPlayer) {
        field.Name = "bossPlayer";
        field.Type = TType.List;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, BossPlayer.Count));
          foreach (PlayerBossFightResponse _iter381 in BossPlayer)
          {
            _iter381.Write(oprot);
          }
          oprot.WriteListEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ListPlayerBossFightResponse(");
      sb.Append("BossPlayer: ");
      sb.Append(BossPlayer);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
